using System.Text.Json;
using System.Text.Json.Serialization;

namespace CodeGen.Natives.Scripts;

public partial class Generators
{
    public class Class
    {
        [JsonPropertyName("class_name")] public string ClassName { get; set; }

        [JsonPropertyName("class_size")] public int ClassSize { get; set; }

        [JsonPropertyName("offsets")] public List<Offset> Offsets { get; set; }

        [JsonPropertyName("metadata")] public List<Metadata>? Metadata { get; set; }

        [JsonPropertyName("inherits")] public string Inherits { get; set; }

        public List<Class> Subclasses { get; set; } = new List<Class>();
        public string SchemaName { get; set; }
    }

    public class Enum
    {
        [JsonPropertyName("enum_name")] public string EnumName { get; set; }

        [JsonPropertyName("enum_size")] public int EnumSize { get; set; }

        [JsonPropertyName("memebers")] public List<Memeber> Members { get; set; }
    }

    public class Memeber
    {
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("value")] public ulong Value { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("var_name")] public string VarName { get; set; }

        [JsonPropertyName("var_type")] public string VarType { get; set; }
    }

    public class Offset
    {
        [JsonPropertyName("field_name")] public string FieldName { get; set; }

        [JsonPropertyName("field_type")] public string FieldType { get; set; }

        [JsonPropertyName("field_ctype")] public string FieldCtype { get; set; }

        [JsonPropertyName("offset")] public int OffsetSize { get; set; }

        [JsonPropertyName("metadata")] public List<Metadata> Metadata { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("schema_name")] public string SchemaName { get; set; }

        [JsonPropertyName("classes")] public List<Class> Classes { get; set; }

        [JsonPropertyName("enums")] public List<Enum>? Enums { get; set; }
    }

    private static string MapVarTypeToCSharpType(string value)
    {
        switch (value)
        {
            case "int32":
                return "int";
            case "int64":
                return "long";
            case "uint8":
                return "sbyte";
            case "float32":
                return "float";
            case "char":
                return "string";
            case "uint32":
                return "uint";
            case "uint64":
                return "ulong";
        }

        if (CleanName(value).EndsWith("*"))
        {
            return $"PointerTo<{CleanName(value).Replace("*", "")}>";
        }

        return CleanName(value);
    }

    private static string CleanName(string value) => value.Replace("::", "__").Replace(" ", "");

    record MemberRow(string VarType, string VarName, int? Offset);
    

    public static void GenerateNativeObjects()
    {
        var jsonPath = Path.Join(Helpers.GetRootDirectory(), "tooling/CodeGen.Natives/cs2_schema.json");
        var jsonString = File.ReadAllText(jsonPath);
        var allSchemas = JsonSerializer.Deserialize<List<Root>>(jsonString);

        var allClasses = allSchemas.Where(x => x.SchemaName != "client.dll").SelectMany(s =>
        {
            return s.Classes.Select(x =>
            {
                x.SchemaName = s.SchemaName;
                return x;
            });
        });
        
        var supportedTypes =
            new HashSet<string>(new[] { "int", "int32", "float", "bool", "uint8", "float32", "char", "uint32", "uint64", "Vector" });
        
        foreach (var name in allSchemas.SelectMany(x => x.Enums ?? Enumerable.Empty<Enum>()).DistinctBy(x => x.EnumName)
                     .Select(x => CleanName(x.EnumName)))
        {
            supportedTypes.Add(name);
        }
        
        foreach (var c in allClasses)
        {
            supportedTypes.Add(CleanName(c.ClassName));
            supportedTypes.Add(CleanName(c.ClassName) + "*");
        }

        var addedMembers = new HashSet<string>();
        
        var addedClasses = new HashSet<string>();
        var allClassDefinitions = allClasses.Select(c =>
        {
            var className = c.ClassName.Replace("::", "__");

            if (addedClasses.Contains(className)) return null;
            var inheritedClassName = c.Inherits?.Split(new string[] { "::" }, StringSplitOptions.None).Last()
                .Replace("::", "__");
            var classDefinition = $@"
    // {c.SchemaName}
    public partial class {className} {(inheritedClassName != null ? $": {inheritedClassName}" : ": NativeObject")} {{
        private const string ThisClassName = ""{className}"";

        public {className} (IntPtr pointer) : base(pointer) {{}}

        [[members]]
    }}";
            
            var networkVarMembers =
                c.Metadata?.Where(x => x.Type != "Unknown").Select(x => new MemberRow(CleanName(x.VarType), x.VarName, null)) ??
                Enumerable.Empty<MemberRow>();

            // Currently disabled, but access to non network vars (aka not accessible via schema)
            var offsetVarMembers = c.Offsets.Select(x => new MemberRow(CleanName(x.FieldCtype), x.FieldName, x.OffsetSize));

            var members = networkVarMembers
                // .Concat(offsetVarMembers)
                .Where(x => supportedTypes.Contains(x.VarType) || x.VarType.StartsWith("CHandle"))
                .Select(m =>
                {
                    var mappedVarType = MapVarTypeToCSharpType(m.VarType);
                    
                    var returnData = $@"
        public {mappedVarType} {m.VarName} 
        {{
            get => Schema.GetSchemaValue<{mappedVarType}>(this.Handle, ThisClassName, ""{m.VarName}"");
            set => Schema.SetSchemaValue<{mappedVarType}>(this.Handle, ThisClassName, ""{m.VarName}"", value);
        }}";
                    return returnData;
                }).ToArray();

            classDefinition = classDefinition.Replace("[[members]]", string.Join("\n", members));

            addedClasses.Add(className);
            return classDefinition;
        }).Where(x => x != null).ToArray();
        
        var result = $@"
using System;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;

namespace CounterStrikeSharp.API.Core
{{
    [[template]]
}}
";
        
        var allEnums = allSchemas.SelectMany(x => x.Enums ?? Enumerable.Empty<Enum>()).DistinctBy(x => x.EnumName)
            .Select(e =>
            {
                return $@"
    public enum {CleanName(e.EnumName)} : ulong {{
        {string.Join(",\n\t\t", e.Members.Select(m => $"{m.Name} = {m.Value}"))}
    }}";
            });
        
        File.WriteAllText(Path.Join(Helpers.GetRootDirectory(), "managed/CounterStrikeSharp.API/Core/Objects.g.cs"),
            result.Replace("[[template]]", string.Join("\n", allClassDefinitions)));
        
        Console.WriteLine($"Generated C# bindings for {allClassDefinitions.Length} native object classes successfully.");
        
        File.WriteAllText(Path.Join(Helpers.GetRootDirectory(), "managed/CounterStrikeSharp.API/Core/Enums.g.cs"), 
            result.Replace("[[template]]",  string.Join("\n", allEnums)));
    }
}
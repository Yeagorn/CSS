// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class magnetted_objects_t : NativeObject
{
    public magnetted_objects_t (IntPtr pointer) : base(pointer) {}

	// hEntity
	[SchemaMember("magnetted_objects_t", "hEntity")]
	public CHandle<CBaseEntity> HEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "magnetted_objects_t", "hEntity");

}

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

public partial class constraint_breakableparams_t : NativeObject
{
    public constraint_breakableparams_t (IntPtr pointer) : base(pointer) {}

	// strength
	[SchemaMember("constraint_breakableparams_t", "strength")]
	public ref float Strength => ref Schema.GetRef<float>(this.Handle, "constraint_breakableparams_t", "strength");

	// forceLimit
	[SchemaMember("constraint_breakableparams_t", "forceLimit")]
	public ref float ForceLimit => ref Schema.GetRef<float>(this.Handle, "constraint_breakableparams_t", "forceLimit");

	// torqueLimit
	[SchemaMember("constraint_breakableparams_t", "torqueLimit")]
	public ref float TorqueLimit => ref Schema.GetRef<float>(this.Handle, "constraint_breakableparams_t", "torqueLimit");

	// bodyMassScale
	[SchemaMember("constraint_breakableparams_t", "bodyMassScale")]
	public Span<float> BodyMassScale => Schema.GetFixedArray<float>(this.Handle, "constraint_breakableparams_t", "bodyMassScale", 2);

	// isActive
	[SchemaMember("constraint_breakableparams_t", "isActive")]
	public ref bool IsActive => ref Schema.GetRef<bool>(this.Handle, "constraint_breakableparams_t", "isActive");

}

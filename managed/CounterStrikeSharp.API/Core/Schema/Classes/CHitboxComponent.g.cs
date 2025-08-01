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

public partial class CHitboxComponent : CEntityComponent
{
    public CHitboxComponent (IntPtr pointer) : base(pointer) {}

	// m_bvDisabledHitGroups
	[SchemaMember("CHitboxComponent", "m_bvDisabledHitGroups")]
	public Span<UInt32> DisabledHitGroups => Schema.GetFixedArray<UInt32>(this.Handle, "CHitboxComponent", "m_bvDisabledHitGroups", 1);

}

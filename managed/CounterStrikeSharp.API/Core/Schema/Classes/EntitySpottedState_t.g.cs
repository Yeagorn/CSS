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

public partial class EntitySpottedState_t : NativeObject
{
    public EntitySpottedState_t (IntPtr pointer) : base(pointer) {}

	// m_bSpotted
	[SchemaMember("EntitySpottedState_t", "m_bSpotted")]
	public ref bool Spotted => ref Schema.GetRef<bool>(this.Handle, "EntitySpottedState_t", "m_bSpotted");

	// m_bSpottedByMask
	[SchemaMember("EntitySpottedState_t", "m_bSpottedByMask")]
	public Span<UInt32> SpottedByMask => Schema.GetFixedArray<UInt32>(this.Handle, "EntitySpottedState_t", "m_bSpottedByMask", 2);

}

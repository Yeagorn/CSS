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

public partial class CBaseFire : CBaseEntity
{
    public CBaseFire (IntPtr pointer) : base(pointer) {}

	// m_flScale
	[SchemaMember("CBaseFire", "m_flScale")]
	public ref float Scale => ref Schema.GetRef<float>(this.Handle, "CBaseFire", "m_flScale");

	// m_flStartScale
	[SchemaMember("CBaseFire", "m_flStartScale")]
	public ref float StartScale => ref Schema.GetRef<float>(this.Handle, "CBaseFire", "m_flStartScale");

	// m_flScaleTime
	[SchemaMember("CBaseFire", "m_flScaleTime")]
	public ref float ScaleTime => ref Schema.GetRef<float>(this.Handle, "CBaseFire", "m_flScaleTime");

	// m_nFlags
	[SchemaMember("CBaseFire", "m_nFlags")]
	public ref UInt32 FireFlags => ref Schema.GetRef<UInt32>(this.Handle, "CBaseFire", "m_nFlags");

}

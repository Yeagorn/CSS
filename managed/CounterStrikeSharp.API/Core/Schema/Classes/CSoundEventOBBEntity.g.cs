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

public partial class CSoundEventOBBEntity : CSoundEventEntity
{
    public CSoundEventOBBEntity (IntPtr pointer) : base(pointer) {}

	// m_vMins
	[SchemaMember("CSoundEventOBBEntity", "m_vMins")]
	public Vector Mins => Schema.GetDeclaredClass<Vector>(this.Handle, "CSoundEventOBBEntity", "m_vMins");

	// m_vMaxs
	[SchemaMember("CSoundEventOBBEntity", "m_vMaxs")]
	public Vector Maxs => Schema.GetDeclaredClass<Vector>(this.Handle, "CSoundEventOBBEntity", "m_vMaxs");

}

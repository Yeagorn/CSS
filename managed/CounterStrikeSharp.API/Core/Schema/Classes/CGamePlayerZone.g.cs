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

public partial class CGamePlayerZone : CRuleBrushEntity
{
    public CGamePlayerZone (IntPtr pointer) : base(pointer) {}

	// m_OnPlayerInZone
	[SchemaMember("CGamePlayerZone", "m_OnPlayerInZone")]
	public CEntityIOOutput OnPlayerInZone => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CGamePlayerZone", "m_OnPlayerInZone");

	// m_OnPlayerOutZone
	[SchemaMember("CGamePlayerZone", "m_OnPlayerOutZone")]
	public CEntityIOOutput OnPlayerOutZone => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CGamePlayerZone", "m_OnPlayerOutZone");

}

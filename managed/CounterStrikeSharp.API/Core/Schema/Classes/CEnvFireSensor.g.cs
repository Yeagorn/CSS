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

public partial class CEnvFireSensor : CBaseEntity
{
    public CEnvFireSensor (IntPtr pointer) : base(pointer) {}

	// m_bEnabled
	[SchemaMember("CEnvFireSensor", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CEnvFireSensor", "m_bEnabled");

	// m_bHeatAtLevel
	[SchemaMember("CEnvFireSensor", "m_bHeatAtLevel")]
	public ref bool HeatAtLevel => ref Schema.GetRef<bool>(this.Handle, "CEnvFireSensor", "m_bHeatAtLevel");

	// m_radius
	[SchemaMember("CEnvFireSensor", "m_radius")]
	public ref float Radius => ref Schema.GetRef<float>(this.Handle, "CEnvFireSensor", "m_radius");

	// m_targetLevel
	[SchemaMember("CEnvFireSensor", "m_targetLevel")]
	public ref float TargetLevel => ref Schema.GetRef<float>(this.Handle, "CEnvFireSensor", "m_targetLevel");

	// m_targetTime
	[SchemaMember("CEnvFireSensor", "m_targetTime")]
	public ref float TargetTime => ref Schema.GetRef<float>(this.Handle, "CEnvFireSensor", "m_targetTime");

	// m_levelTime
	[SchemaMember("CEnvFireSensor", "m_levelTime")]
	public ref float LevelTime => ref Schema.GetRef<float>(this.Handle, "CEnvFireSensor", "m_levelTime");

	// m_OnHeatLevelStart
	[SchemaMember("CEnvFireSensor", "m_OnHeatLevelStart")]
	public CEntityIOOutput OnHeatLevelStart => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CEnvFireSensor", "m_OnHeatLevelStart");

	// m_OnHeatLevelEnd
	[SchemaMember("CEnvFireSensor", "m_OnHeatLevelEnd")]
	public CEntityIOOutput OnHeatLevelEnd => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CEnvFireSensor", "m_OnHeatLevelEnd");

}

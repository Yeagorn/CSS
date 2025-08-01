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

public partial class CPointAngularVelocitySensor : CPointEntity
{
    public CPointAngularVelocitySensor (IntPtr pointer) : base(pointer) {}

	// m_hTargetEntity
	[SchemaMember("CPointAngularVelocitySensor", "m_hTargetEntity")]
	public CHandle<CBaseEntity> TargetEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointAngularVelocitySensor", "m_hTargetEntity");

	// m_flThreshold
	[SchemaMember("CPointAngularVelocitySensor", "m_flThreshold")]
	public ref float Threshold => ref Schema.GetRef<float>(this.Handle, "CPointAngularVelocitySensor", "m_flThreshold");

	// m_nLastCompareResult
	[SchemaMember("CPointAngularVelocitySensor", "m_nLastCompareResult")]
	public ref Int32 LastCompareResult => ref Schema.GetRef<Int32>(this.Handle, "CPointAngularVelocitySensor", "m_nLastCompareResult");

	// m_nLastFireResult
	[SchemaMember("CPointAngularVelocitySensor", "m_nLastFireResult")]
	public ref Int32 LastFireResult => ref Schema.GetRef<Int32>(this.Handle, "CPointAngularVelocitySensor", "m_nLastFireResult");

	// m_flFireTime
	[SchemaMember("CPointAngularVelocitySensor", "m_flFireTime")]
	public ref float FireTime => ref Schema.GetRef<float>(this.Handle, "CPointAngularVelocitySensor", "m_flFireTime");

	// m_flFireInterval
	[SchemaMember("CPointAngularVelocitySensor", "m_flFireInterval")]
	public ref float FireInterval => ref Schema.GetRef<float>(this.Handle, "CPointAngularVelocitySensor", "m_flFireInterval");

	// m_flLastAngVelocity
	[SchemaMember("CPointAngularVelocitySensor", "m_flLastAngVelocity")]
	public ref float LastAngVelocity => ref Schema.GetRef<float>(this.Handle, "CPointAngularVelocitySensor", "m_flLastAngVelocity");

	// m_lastOrientation
	[SchemaMember("CPointAngularVelocitySensor", "m_lastOrientation")]
	public QAngle LastOrientation => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPointAngularVelocitySensor", "m_lastOrientation");

	// m_vecAxis
	[SchemaMember("CPointAngularVelocitySensor", "m_vecAxis")]
	public Vector Axis => Schema.GetDeclaredClass<Vector>(this.Handle, "CPointAngularVelocitySensor", "m_vecAxis");

	// m_bUseHelper
	[SchemaMember("CPointAngularVelocitySensor", "m_bUseHelper")]
	public ref bool UseHelper => ref Schema.GetRef<bool>(this.Handle, "CPointAngularVelocitySensor", "m_bUseHelper");

	// m_OnLessThan
	[SchemaMember("CPointAngularVelocitySensor", "m_OnLessThan")]
	public CEntityIOOutput OnLessThan => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngularVelocitySensor", "m_OnLessThan");

	// m_OnLessThanOrEqualTo
	[SchemaMember("CPointAngularVelocitySensor", "m_OnLessThanOrEqualTo")]
	public CEntityIOOutput OnLessThanOrEqualTo => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngularVelocitySensor", "m_OnLessThanOrEqualTo");

	// m_OnGreaterThan
	[SchemaMember("CPointAngularVelocitySensor", "m_OnGreaterThan")]
	public CEntityIOOutput OnGreaterThan => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngularVelocitySensor", "m_OnGreaterThan");

	// m_OnGreaterThanOrEqualTo
	[SchemaMember("CPointAngularVelocitySensor", "m_OnGreaterThanOrEqualTo")]
	public CEntityIOOutput OnGreaterThanOrEqualTo => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngularVelocitySensor", "m_OnGreaterThanOrEqualTo");

	// m_OnEqualTo
	[SchemaMember("CPointAngularVelocitySensor", "m_OnEqualTo")]
	public CEntityIOOutput OnEqualTo => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngularVelocitySensor", "m_OnEqualTo");

}

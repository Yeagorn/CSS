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

public partial class CBaseCSGrenadeProjectile : CBaseGrenade
{
    public CBaseCSGrenadeProjectile (IntPtr pointer) : base(pointer) {}

	// m_vInitialPosition
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vInitialPosition")]
	public Vector InitialPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vInitialPosition");

	// m_vInitialVelocity
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vInitialVelocity")]
	public Vector InitialVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vInitialVelocity");

	// m_nBounces
	[SchemaMember("CBaseCSGrenadeProjectile", "m_nBounces")]
	public ref Int32 Bounces => ref Schema.GetRef<Int32>(this.Handle, "CBaseCSGrenadeProjectile", "m_nBounces");

	// m_nExplodeEffectIndex
	[SchemaMember("CBaseCSGrenadeProjectile", "m_nExplodeEffectIndex")]
	public CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> ExplodeEffectIndex => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(this.Handle, "CBaseCSGrenadeProjectile", "m_nExplodeEffectIndex");

	// m_nExplodeEffectTickBegin
	[SchemaMember("CBaseCSGrenadeProjectile", "m_nExplodeEffectTickBegin")]
	public ref Int32 ExplodeEffectTickBegin => ref Schema.GetRef<Int32>(this.Handle, "CBaseCSGrenadeProjectile", "m_nExplodeEffectTickBegin");

	// m_vecExplodeEffectOrigin
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vecExplodeEffectOrigin")]
	public Vector ExplodeEffectOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vecExplodeEffectOrigin");

	// m_flSpawnTime
	[SchemaMember("CBaseCSGrenadeProjectile", "m_flSpawnTime")]
	public ref float SpawnTime => ref Schema.GetRef<float>(this.Handle, "CBaseCSGrenadeProjectile", "m_flSpawnTime");

	// m_unOGSExtraFlags
	[SchemaMember("CBaseCSGrenadeProjectile", "m_unOGSExtraFlags")]
	public ref byte OGSExtraFlags => ref Schema.GetRef<byte>(this.Handle, "CBaseCSGrenadeProjectile", "m_unOGSExtraFlags");

	// m_bDetonationRecorded
	[SchemaMember("CBaseCSGrenadeProjectile", "m_bDetonationRecorded")]
	public ref bool DetonationRecorded => ref Schema.GetRef<bool>(this.Handle, "CBaseCSGrenadeProjectile", "m_bDetonationRecorded");

	// m_nItemIndex
	[SchemaMember("CBaseCSGrenadeProjectile", "m_nItemIndex")]
	public ref UInt16 ItemIndex => ref Schema.GetRef<UInt16>(this.Handle, "CBaseCSGrenadeProjectile", "m_nItemIndex");

	// m_vecOriginalSpawnLocation
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vecOriginalSpawnLocation")]
	public Vector OriginalSpawnLocation => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vecOriginalSpawnLocation");

	// m_flLastBounceSoundTime
	[SchemaMember("CBaseCSGrenadeProjectile", "m_flLastBounceSoundTime")]
	public ref float LastBounceSoundTime => ref Schema.GetRef<float>(this.Handle, "CBaseCSGrenadeProjectile", "m_flLastBounceSoundTime");

	// m_vecGrenadeSpin
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vecGrenadeSpin")]
	public Vector GrenadeSpin => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vecGrenadeSpin");

	// m_vecLastHitSurfaceNormal
	[SchemaMember("CBaseCSGrenadeProjectile", "m_vecLastHitSurfaceNormal")]
	public Vector LastHitSurfaceNormal => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseCSGrenadeProjectile", "m_vecLastHitSurfaceNormal");

	// m_nTicksAtZeroVelocity
	[SchemaMember("CBaseCSGrenadeProjectile", "m_nTicksAtZeroVelocity")]
	public ref Int32 TicksAtZeroVelocity => ref Schema.GetRef<Int32>(this.Handle, "CBaseCSGrenadeProjectile", "m_nTicksAtZeroVelocity");

	// m_bHasEverHitEnemy
	[SchemaMember("CBaseCSGrenadeProjectile", "m_bHasEverHitEnemy")]
	public ref bool HasEverHitEnemy => ref Schema.GetRef<bool>(this.Handle, "CBaseCSGrenadeProjectile", "m_bHasEverHitEnemy");

}

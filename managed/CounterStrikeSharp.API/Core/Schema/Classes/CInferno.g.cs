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

public partial class CInferno : CBaseModelEntity
{
    public CInferno (IntPtr pointer) : base(pointer) {}

	// m_firePositions
	[SchemaMember("CInferno", "m_firePositions")]
	public Span<Vector> FirePositions => Schema.GetFixedArray<Vector>(this.Handle, "CInferno", "m_firePositions", 64);

	// m_fireParentPositions
	[SchemaMember("CInferno", "m_fireParentPositions")]
	public Span<Vector> FireParentPositions => Schema.GetFixedArray<Vector>(this.Handle, "CInferno", "m_fireParentPositions", 64);

	// m_bFireIsBurning
	[SchemaMember("CInferno", "m_bFireIsBurning")]
	public Span<bool> FireIsBurning => Schema.GetFixedArray<bool>(this.Handle, "CInferno", "m_bFireIsBurning", 64);

	// m_BurnNormal
	[SchemaMember("CInferno", "m_BurnNormal")]
	public Span<Vector> BurnNormal => Schema.GetFixedArray<Vector>(this.Handle, "CInferno", "m_BurnNormal", 64);

	// m_fireCount
	[SchemaMember("CInferno", "m_fireCount")]
	public ref Int32 FireCount => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_fireCount");

	// m_nInfernoType
	[SchemaMember("CInferno", "m_nInfernoType")]
	public ref Int32 InfernoType => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_nInfernoType");

	// m_nFireEffectTickBegin
	[SchemaMember("CInferno", "m_nFireEffectTickBegin")]
	public ref Int32 FireEffectTickBegin => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_nFireEffectTickBegin");

	// m_nFireLifetime
	[SchemaMember("CInferno", "m_nFireLifetime")]
	public ref float FireLifetime => ref Schema.GetRef<float>(this.Handle, "CInferno", "m_nFireLifetime");

	// m_bInPostEffectTime
	[SchemaMember("CInferno", "m_bInPostEffectTime")]
	public ref bool InPostEffectTime => ref Schema.GetRef<bool>(this.Handle, "CInferno", "m_bInPostEffectTime");

	// m_nFiresExtinguishCount
	[SchemaMember("CInferno", "m_nFiresExtinguishCount")]
	public ref Int32 FiresExtinguishCount => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_nFiresExtinguishCount");

	// m_bWasCreatedInSmoke
	[SchemaMember("CInferno", "m_bWasCreatedInSmoke")]
	public ref bool WasCreatedInSmoke => ref Schema.GetRef<bool>(this.Handle, "CInferno", "m_bWasCreatedInSmoke");

	// m_extent
	[SchemaMember("CInferno", "m_extent")]
	public Extent Extent => Schema.GetDeclaredClass<Extent>(this.Handle, "CInferno", "m_extent");

	// m_damageTimer
	[SchemaMember("CInferno", "m_damageTimer")]
	public CountdownTimer DamageTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CInferno", "m_damageTimer");

	// m_damageRampTimer
	[SchemaMember("CInferno", "m_damageRampTimer")]
	public CountdownTimer DamageRampTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CInferno", "m_damageRampTimer");

	// m_splashVelocity
	[SchemaMember("CInferno", "m_splashVelocity")]
	public Vector SplashVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CInferno", "m_splashVelocity");

	// m_InitialSplashVelocity
	[SchemaMember("CInferno", "m_InitialSplashVelocity")]
	public Vector InitialSplashVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CInferno", "m_InitialSplashVelocity");

	// m_startPos
	[SchemaMember("CInferno", "m_startPos")]
	public Vector StartPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CInferno", "m_startPos");

	// m_vecOriginalSpawnLocation
	[SchemaMember("CInferno", "m_vecOriginalSpawnLocation")]
	public Vector OriginalSpawnLocation => Schema.GetDeclaredClass<Vector>(this.Handle, "CInferno", "m_vecOriginalSpawnLocation");

	// m_activeTimer
	[SchemaMember("CInferno", "m_activeTimer")]
	public IntervalTimer ActiveTimer => Schema.GetDeclaredClass<IntervalTimer>(this.Handle, "CInferno", "m_activeTimer");

	// m_fireSpawnOffset
	[SchemaMember("CInferno", "m_fireSpawnOffset")]
	public ref Int32 FireSpawnOffset => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_fireSpawnOffset");

	// m_nMaxFlames
	[SchemaMember("CInferno", "m_nMaxFlames")]
	public ref Int32 MaxFlames => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_nMaxFlames");

	// m_nSpreadCount
	[SchemaMember("CInferno", "m_nSpreadCount")]
	public ref Int32 SpreadCount => ref Schema.GetRef<Int32>(this.Handle, "CInferno", "m_nSpreadCount");

	// m_BookkeepingTimer
	[SchemaMember("CInferno", "m_BookkeepingTimer")]
	public CountdownTimer BookkeepingTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CInferno", "m_BookkeepingTimer");

	// m_NextSpreadTimer
	[SchemaMember("CInferno", "m_NextSpreadTimer")]
	public CountdownTimer NextSpreadTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CInferno", "m_NextSpreadTimer");

	// m_nSourceItemDefIndex
	[SchemaMember("CInferno", "m_nSourceItemDefIndex")]
	public ref UInt16 SourceItemDefIndex => ref Schema.GetRef<UInt16>(this.Handle, "CInferno", "m_nSourceItemDefIndex");

}

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

public partial class CCSPlayerPawnBase : CBasePlayerPawn
{
    public CCSPlayerPawnBase (IntPtr pointer) : base(pointer) {}

	// m_CTouchExpansionComponent
	[SchemaMember("CCSPlayerPawnBase", "m_CTouchExpansionComponent")]
	public CTouchExpansionComponent CTouchExpansionComponent => Schema.GetDeclaredClass<CTouchExpansionComponent>(this.Handle, "CCSPlayerPawnBase", "m_CTouchExpansionComponent");

	// m_pPingServices
	[SchemaMember("CCSPlayerPawnBase", "m_pPingServices")]
	public CCSPlayer_PingServices? PingServices => Schema.GetPointer<CCSPlayer_PingServices>(this.Handle, "CCSPlayerPawnBase", "m_pPingServices");

	// m_pViewModelServices
	[SchemaMember("CCSPlayerPawnBase", "m_pViewModelServices")]
	public CPlayer_ViewModelServices? ViewModelServices => Schema.GetPointer<CPlayer_ViewModelServices>(this.Handle, "CCSPlayerPawnBase", "m_pViewModelServices");

	// m_blindUntilTime
	[SchemaMember("CCSPlayerPawnBase", "m_blindUntilTime")]
	public ref float BlindUntilTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_blindUntilTime");

	// m_blindStartTime
	[SchemaMember("CCSPlayerPawnBase", "m_blindStartTime")]
	public ref float BlindStartTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_blindStartTime");

	// m_iPlayerState
	[SchemaMember("CCSPlayerPawnBase", "m_iPlayerState")]
	public ref CSPlayerState PlayerState => ref Schema.GetRef<CSPlayerState>(this.Handle, "CCSPlayerPawnBase", "m_iPlayerState");

	// m_bRespawning
	[SchemaMember("CCSPlayerPawnBase", "m_bRespawning")]
	public ref bool Respawning => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bRespawning");

	// m_fImmuneToGunGameDamageTime
	[SchemaMember("CCSPlayerPawnBase", "m_fImmuneToGunGameDamageTime")]
	public ref float ImmuneToGunGameDamageTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fImmuneToGunGameDamageTime");

	// m_bGunGameImmunity
	[SchemaMember("CCSPlayerPawnBase", "m_bGunGameImmunity")]
	public ref bool GunGameImmunity => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bGunGameImmunity");

	// m_fMolotovDamageTime
	[SchemaMember("CCSPlayerPawnBase", "m_fMolotovDamageTime")]
	public ref float MolotovDamageTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fMolotovDamageTime");

	// m_bHasMovedSinceSpawn
	[SchemaMember("CCSPlayerPawnBase", "m_bHasMovedSinceSpawn")]
	public ref bool HasMovedSinceSpawn => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHasMovedSinceSpawn");

	// m_iNumSpawns
	[SchemaMember("CCSPlayerPawnBase", "m_iNumSpawns")]
	public ref Int32 NumSpawns => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iNumSpawns");

	// m_flIdleTimeSinceLastAction
	[SchemaMember("CCSPlayerPawnBase", "m_flIdleTimeSinceLastAction")]
	public ref float IdleTimeSinceLastAction => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flIdleTimeSinceLastAction");

	// m_fNextRadarUpdateTime
	[SchemaMember("CCSPlayerPawnBase", "m_fNextRadarUpdateTime")]
	public ref float NextRadarUpdateTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fNextRadarUpdateTime");

	// m_flFlashDuration
	[SchemaMember("CCSPlayerPawnBase", "m_flFlashDuration")]
	public ref float FlashDuration => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flFlashDuration");

	// m_flFlashMaxAlpha
	[SchemaMember("CCSPlayerPawnBase", "m_flFlashMaxAlpha")]
	public ref float FlashMaxAlpha => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flFlashMaxAlpha");

	// m_flProgressBarStartTime
	[SchemaMember("CCSPlayerPawnBase", "m_flProgressBarStartTime")]
	public ref float ProgressBarStartTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flProgressBarStartTime");

	// m_iProgressBarDuration
	[SchemaMember("CCSPlayerPawnBase", "m_iProgressBarDuration")]
	public ref Int32 ProgressBarDuration => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iProgressBarDuration");

	// m_angEyeAngles
	[SchemaMember("CCSPlayerPawnBase", "m_angEyeAngles")]
	public QAngle EyeAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_angEyeAngles");

	// m_wasNotKilledNaturally
	[SchemaMember("CCSPlayerPawnBase", "m_wasNotKilledNaturally")]
	public ref bool WasNotKilledNaturally => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_wasNotKilledNaturally");

	// m_bCommittingSuicideOnTeamChange
	[SchemaMember("CCSPlayerPawnBase", "m_bCommittingSuicideOnTeamChange")]
	public ref bool CommittingSuicideOnTeamChange => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bCommittingSuicideOnTeamChange");

	// m_hOriginalController
	[SchemaMember("CCSPlayerPawnBase", "m_hOriginalController")]
	public CHandle<CCSPlayerController> OriginalController => Schema.GetDeclaredClass<CHandle<CCSPlayerController>>(this.Handle, "CCSPlayerPawnBase", "m_hOriginalController");

}

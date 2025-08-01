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

public partial class CBaseButton : CBaseToggle
{
    public CBaseButton (IntPtr pointer) : base(pointer) {}

	// m_angMoveEntitySpace
	[SchemaMember("CBaseButton", "m_angMoveEntitySpace")]
	public QAngle MoveEntitySpace => Schema.GetDeclaredClass<QAngle>(this.Handle, "CBaseButton", "m_angMoveEntitySpace");

	// m_fStayPushed
	[SchemaMember("CBaseButton", "m_fStayPushed")]
	public ref bool StayPushed => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_fStayPushed");

	// m_fRotating
	[SchemaMember("CBaseButton", "m_fRotating")]
	public ref bool Rotating => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_fRotating");

	// m_ls
	[SchemaMember("CBaseButton", "m_ls")]
	public locksound_t Ls => Schema.GetDeclaredClass<locksound_t>(this.Handle, "CBaseButton", "m_ls");

	// m_sUseSound
	[SchemaMember("CBaseButton", "m_sUseSound")]
	public string UseSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_sUseSound"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_sUseSound", value); }
	}

	// m_sLockedSound
	[SchemaMember("CBaseButton", "m_sLockedSound")]
	public string LockedSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_sLockedSound"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_sLockedSound", value); }
	}

	// m_sUnlockedSound
	[SchemaMember("CBaseButton", "m_sUnlockedSound")]
	public string UnlockedSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_sUnlockedSound"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_sUnlockedSound", value); }
	}

	// m_sOverrideAnticipationName
	[SchemaMember("CBaseButton", "m_sOverrideAnticipationName")]
	public string OverrideAnticipationName
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_sOverrideAnticipationName"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_sOverrideAnticipationName", value); }
	}

	// m_bLocked
	[SchemaMember("CBaseButton", "m_bLocked")]
	public ref bool Locked => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_bLocked");

	// m_bDisabled
	[SchemaMember("CBaseButton", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_bDisabled");

	// m_flUseLockedTime
	[SchemaMember("CBaseButton", "m_flUseLockedTime")]
	public ref float UseLockedTime => ref Schema.GetRef<float>(this.Handle, "CBaseButton", "m_flUseLockedTime");

	// m_bSolidBsp
	[SchemaMember("CBaseButton", "m_bSolidBsp")]
	public ref bool SolidBsp => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_bSolidBsp");

	// m_OnDamaged
	[SchemaMember("CBaseButton", "m_OnDamaged")]
	public CEntityIOOutput OnDamaged => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseButton", "m_OnDamaged");

	// m_OnPressed
	[SchemaMember("CBaseButton", "m_OnPressed")]
	public CEntityIOOutput OnPressed => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseButton", "m_OnPressed");

	// m_OnUseLocked
	[SchemaMember("CBaseButton", "m_OnUseLocked")]
	public CEntityIOOutput OnUseLocked => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseButton", "m_OnUseLocked");

	// m_OnIn
	[SchemaMember("CBaseButton", "m_OnIn")]
	public CEntityIOOutput OnIn => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseButton", "m_OnIn");

	// m_OnOut
	[SchemaMember("CBaseButton", "m_OnOut")]
	public CEntityIOOutput OnOut => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseButton", "m_OnOut");

	// m_nState
	[SchemaMember("CBaseButton", "m_nState")]
	public ref Int32 State => ref Schema.GetRef<Int32>(this.Handle, "CBaseButton", "m_nState");

	// m_hConstraint
	[SchemaMember("CBaseButton", "m_hConstraint")]
	public CHandle<CEntityInstance> Constraint => Schema.GetDeclaredClass<CHandle<CEntityInstance>>(this.Handle, "CBaseButton", "m_hConstraint");

	// m_hConstraintParent
	[SchemaMember("CBaseButton", "m_hConstraintParent")]
	public CHandle<CEntityInstance> ConstraintParent => Schema.GetDeclaredClass<CHandle<CEntityInstance>>(this.Handle, "CBaseButton", "m_hConstraintParent");

	// m_bForceNpcExclude
	[SchemaMember("CBaseButton", "m_bForceNpcExclude")]
	public ref bool ForceNpcExclude => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_bForceNpcExclude");

	// m_sGlowEntity
	[SchemaMember("CBaseButton", "m_sGlowEntity")]
	public string SGlowEntity
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_sGlowEntity"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_sGlowEntity", value); }
	}

	// m_glowEntity
	[SchemaMember("CBaseButton", "m_glowEntity")]
	public CHandle<CBaseModelEntity> GlowEntity => Schema.GetDeclaredClass<CHandle<CBaseModelEntity>>(this.Handle, "CBaseButton", "m_glowEntity");

	// m_usable
	[SchemaMember("CBaseButton", "m_usable")]
	public ref bool Usable => ref Schema.GetRef<bool>(this.Handle, "CBaseButton", "m_usable");

	// m_szDisplayText
	[SchemaMember("CBaseButton", "m_szDisplayText")]
	public string DisplayText
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseButton", "m_szDisplayText"); }
		set { Schema.SetString(this.Handle, "CBaseButton", "m_szDisplayText", value); }
	}

}

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

public partial class CEnvExplosion : CModelPointEntity
{
    public CEnvExplosion (IntPtr pointer) : base(pointer) {}

	// m_iMagnitude
	[SchemaMember("CEnvExplosion", "m_iMagnitude")]
	public ref Int32 Magnitude => ref Schema.GetRef<Int32>(this.Handle, "CEnvExplosion", "m_iMagnitude");

	// m_flPlayerDamage
	[SchemaMember("CEnvExplosion", "m_flPlayerDamage")]
	public ref float PlayerDamage => ref Schema.GetRef<float>(this.Handle, "CEnvExplosion", "m_flPlayerDamage");

	// m_iRadiusOverride
	[SchemaMember("CEnvExplosion", "m_iRadiusOverride")]
	public ref Int32 RadiusOverride => ref Schema.GetRef<Int32>(this.Handle, "CEnvExplosion", "m_iRadiusOverride");

	// m_flInnerRadius
	[SchemaMember("CEnvExplosion", "m_flInnerRadius")]
	public ref float InnerRadius => ref Schema.GetRef<float>(this.Handle, "CEnvExplosion", "m_flInnerRadius");

	// m_spriteScale
	[SchemaMember("CEnvExplosion", "m_spriteScale")]
	public ref Int32 SpriteScale => ref Schema.GetRef<Int32>(this.Handle, "CEnvExplosion", "m_spriteScale");

	// m_flDamageForce
	[SchemaMember("CEnvExplosion", "m_flDamageForce")]
	public ref float DamageForce => ref Schema.GetRef<float>(this.Handle, "CEnvExplosion", "m_flDamageForce");

	// m_hInflictor
	[SchemaMember("CEnvExplosion", "m_hInflictor")]
	public CHandle<CBaseEntity> Inflictor => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CEnvExplosion", "m_hInflictor");

	// m_iCustomDamageType
	[SchemaMember("CEnvExplosion", "m_iCustomDamageType")]
	public ref DamageTypes_t CustomDamageType => ref Schema.GetRef<DamageTypes_t>(this.Handle, "CEnvExplosion", "m_iCustomDamageType");

	// m_bCreateDebris
	[SchemaMember("CEnvExplosion", "m_bCreateDebris")]
	public ref bool CreateDebris => ref Schema.GetRef<bool>(this.Handle, "CEnvExplosion", "m_bCreateDebris");

	// m_iszExplosionType
	[SchemaMember("CEnvExplosion", "m_iszExplosionType")]
	public string ExplosionType
	{
		get { return Schema.GetUtf8String(this.Handle, "CEnvExplosion", "m_iszExplosionType"); }
		set { Schema.SetString(this.Handle, "CEnvExplosion", "m_iszExplosionType", value); }
	}

	// m_iszCustomEffectName
	[SchemaMember("CEnvExplosion", "m_iszCustomEffectName")]
	public string CustomEffectName
	{
		get { return Schema.GetUtf8String(this.Handle, "CEnvExplosion", "m_iszCustomEffectName"); }
		set { Schema.SetString(this.Handle, "CEnvExplosion", "m_iszCustomEffectName", value); }
	}

	// m_iszCustomSoundName
	[SchemaMember("CEnvExplosion", "m_iszCustomSoundName")]
	public string CustomSoundName
	{
		get { return Schema.GetUtf8String(this.Handle, "CEnvExplosion", "m_iszCustomSoundName"); }
		set { Schema.SetString(this.Handle, "CEnvExplosion", "m_iszCustomSoundName", value); }
	}

	// m_iClassIgnore
	[SchemaMember("CEnvExplosion", "m_iClassIgnore")]
	public ref Class_T ClassIgnore => ref Schema.GetRef<Class_T>(this.Handle, "CEnvExplosion", "m_iClassIgnore");

	// m_iClassIgnore2
	[SchemaMember("CEnvExplosion", "m_iClassIgnore2")]
	public ref Class_T ClassIgnore2 => ref Schema.GetRef<Class_T>(this.Handle, "CEnvExplosion", "m_iClassIgnore2");

	// m_iszEntityIgnoreName
	[SchemaMember("CEnvExplosion", "m_iszEntityIgnoreName")]
	public string EntityIgnoreName
	{
		get { return Schema.GetUtf8String(this.Handle, "CEnvExplosion", "m_iszEntityIgnoreName"); }
		set { Schema.SetString(this.Handle, "CEnvExplosion", "m_iszEntityIgnoreName", value); }
	}

	// m_hEntityIgnore
	[SchemaMember("CEnvExplosion", "m_hEntityIgnore")]
	public CHandle<CBaseEntity> EntityIgnore => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CEnvExplosion", "m_hEntityIgnore");

}

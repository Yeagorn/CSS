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

public partial class CAmbientGeneric : CPointEntity
{
    public CAmbientGeneric (IntPtr pointer) : base(pointer) {}

	// m_radius
	[SchemaMember("CAmbientGeneric", "m_radius")]
	public ref float Radius => ref Schema.GetRef<float>(this.Handle, "CAmbientGeneric", "m_radius");

	// m_flMaxRadius
	[SchemaMember("CAmbientGeneric", "m_flMaxRadius")]
	public ref float MaxRadius => ref Schema.GetRef<float>(this.Handle, "CAmbientGeneric", "m_flMaxRadius");

	// m_iSoundLevel
	[SchemaMember("CAmbientGeneric", "m_iSoundLevel")]
	public ref soundlevel_t SoundLevel => ref Schema.GetRef<soundlevel_t>(this.Handle, "CAmbientGeneric", "m_iSoundLevel");

	// m_dpv
	[SchemaMember("CAmbientGeneric", "m_dpv")]
	public dynpitchvol_t Dpv => Schema.GetDeclaredClass<dynpitchvol_t>(this.Handle, "CAmbientGeneric", "m_dpv");

	// m_fActive
	[SchemaMember("CAmbientGeneric", "m_fActive")]
	public ref bool Active => ref Schema.GetRef<bool>(this.Handle, "CAmbientGeneric", "m_fActive");

	// m_fLooping
	[SchemaMember("CAmbientGeneric", "m_fLooping")]
	public ref bool Looping => ref Schema.GetRef<bool>(this.Handle, "CAmbientGeneric", "m_fLooping");

	// m_iszSound
	[SchemaMember("CAmbientGeneric", "m_iszSound")]
	public string Sound
	{
		get { return Schema.GetUtf8String(this.Handle, "CAmbientGeneric", "m_iszSound"); }
		set { Schema.SetString(this.Handle, "CAmbientGeneric", "m_iszSound", value); }
	}

	// m_sSourceEntName
	[SchemaMember("CAmbientGeneric", "m_sSourceEntName")]
	public string SourceEntName
	{
		get { return Schema.GetUtf8String(this.Handle, "CAmbientGeneric", "m_sSourceEntName"); }
		set { Schema.SetString(this.Handle, "CAmbientGeneric", "m_sSourceEntName", value); }
	}

	// m_hSoundSource
	[SchemaMember("CAmbientGeneric", "m_hSoundSource")]
	public CHandle<CBaseEntity> SoundSource => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CAmbientGeneric", "m_hSoundSource");

	// m_nSoundSourceEntIndex
	[SchemaMember("CAmbientGeneric", "m_nSoundSourceEntIndex")]
	public CEntityIndex SoundSourceEntIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CAmbientGeneric", "m_nSoundSourceEntIndex");

}

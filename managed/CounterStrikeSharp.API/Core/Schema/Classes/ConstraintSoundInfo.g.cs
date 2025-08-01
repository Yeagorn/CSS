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

public partial class ConstraintSoundInfo : NativeObject
{
    public ConstraintSoundInfo (IntPtr pointer) : base(pointer) {}

	// m_vSampler
	[SchemaMember("ConstraintSoundInfo", "m_vSampler")]
	public VelocitySampler Sampler => Schema.GetDeclaredClass<VelocitySampler>(this.Handle, "ConstraintSoundInfo", "m_vSampler");

	// m_soundProfile
	[SchemaMember("ConstraintSoundInfo", "m_soundProfile")]
	public SimpleConstraintSoundProfile SoundProfile => Schema.GetDeclaredClass<SimpleConstraintSoundProfile>(this.Handle, "ConstraintSoundInfo", "m_soundProfile");

	// m_forwardAxis
	[SchemaMember("ConstraintSoundInfo", "m_forwardAxis")]
	public Vector ForwardAxis => Schema.GetDeclaredClass<Vector>(this.Handle, "ConstraintSoundInfo", "m_forwardAxis");

	// m_iszTravelSoundFwd
	[SchemaMember("ConstraintSoundInfo", "m_iszTravelSoundFwd")]
	public string TravelSoundFwd
	{
		get { return Schema.GetUtf8String(this.Handle, "ConstraintSoundInfo", "m_iszTravelSoundFwd"); }
		set { Schema.SetString(this.Handle, "ConstraintSoundInfo", "m_iszTravelSoundFwd", value); }
	}

	// m_iszTravelSoundBack
	[SchemaMember("ConstraintSoundInfo", "m_iszTravelSoundBack")]
	public string TravelSoundBack
	{
		get { return Schema.GetUtf8String(this.Handle, "ConstraintSoundInfo", "m_iszTravelSoundBack"); }
		set { Schema.SetString(this.Handle, "ConstraintSoundInfo", "m_iszTravelSoundBack", value); }
	}

	// m_iszReversalSounds
	[SchemaMember("ConstraintSoundInfo", "m_iszReversalSounds")]
	public Span<string> ReversalSounds => Schema.GetFixedArray<string>(this.Handle, "ConstraintSoundInfo", "m_iszReversalSounds", 3);

	// m_bPlayTravelSound
	[SchemaMember("ConstraintSoundInfo", "m_bPlayTravelSound")]
	public ref bool PlayTravelSound => ref Schema.GetRef<bool>(this.Handle, "ConstraintSoundInfo", "m_bPlayTravelSound");

	// m_bPlayReversalSound
	[SchemaMember("ConstraintSoundInfo", "m_bPlayReversalSound")]
	public ref bool PlayReversalSound => ref Schema.GetRef<bool>(this.Handle, "ConstraintSoundInfo", "m_bPlayReversalSound");

}

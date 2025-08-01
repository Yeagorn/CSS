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

public partial class CFuncElectrifiedVolume : CFuncBrush
{
    public CFuncElectrifiedVolume (IntPtr pointer) : base(pointer) {}

	// m_EffectName
	[SchemaMember("CFuncElectrifiedVolume", "m_EffectName")]
	public string EffectName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncElectrifiedVolume", "m_EffectName"); }
		set { Schema.SetString(this.Handle, "CFuncElectrifiedVolume", "m_EffectName", value); }
	}

	// m_EffectInterpenetrateName
	[SchemaMember("CFuncElectrifiedVolume", "m_EffectInterpenetrateName")]
	public string EffectInterpenetrateName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncElectrifiedVolume", "m_EffectInterpenetrateName"); }
		set { Schema.SetString(this.Handle, "CFuncElectrifiedVolume", "m_EffectInterpenetrateName", value); }
	}

	// m_EffectZapName
	[SchemaMember("CFuncElectrifiedVolume", "m_EffectZapName")]
	public string EffectZapName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncElectrifiedVolume", "m_EffectZapName"); }
		set { Schema.SetString(this.Handle, "CFuncElectrifiedVolume", "m_EffectZapName", value); }
	}

	// m_iszEffectSource
	[SchemaMember("CFuncElectrifiedVolume", "m_iszEffectSource")]
	public string EffectSource
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncElectrifiedVolume", "m_iszEffectSource"); }
		set { Schema.SetString(this.Handle, "CFuncElectrifiedVolume", "m_iszEffectSource", value); }
	}

}

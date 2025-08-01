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

public partial class CMessage : CPointEntity
{
    public CMessage (IntPtr pointer) : base(pointer) {}

	// m_iszMessage
	[SchemaMember("CMessage", "m_iszMessage")]
	public string Message
	{
		get { return Schema.GetUtf8String(this.Handle, "CMessage", "m_iszMessage"); }
		set { Schema.SetString(this.Handle, "CMessage", "m_iszMessage", value); }
	}

	// m_MessageVolume
	[SchemaMember("CMessage", "m_MessageVolume")]
	public ref float MessageVolume => ref Schema.GetRef<float>(this.Handle, "CMessage", "m_MessageVolume");

	// m_MessageAttenuation
	[SchemaMember("CMessage", "m_MessageAttenuation")]
	public ref Int32 MessageAttenuation => ref Schema.GetRef<Int32>(this.Handle, "CMessage", "m_MessageAttenuation");

	// m_Radius
	[SchemaMember("CMessage", "m_Radius")]
	public ref float Radius => ref Schema.GetRef<float>(this.Handle, "CMessage", "m_Radius");

	// m_sNoise
	[SchemaMember("CMessage", "m_sNoise")]
	public string Noise
	{
		get { return Schema.GetUtf8String(this.Handle, "CMessage", "m_sNoise"); }
		set { Schema.SetString(this.Handle, "CMessage", "m_sNoise", value); }
	}

	// m_OnShowMessage
	[SchemaMember("CMessage", "m_OnShowMessage")]
	public CEntityIOOutput OnShowMessage => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMessage", "m_OnShowMessage");

}

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

public partial class CGameText : CRulePointEntity
{
    public CGameText (IntPtr pointer) : base(pointer) {}

	// m_iszMessage
	[SchemaMember("CGameText", "m_iszMessage")]
	public string Message
	{
		get { return Schema.GetUtf8String(this.Handle, "CGameText", "m_iszMessage"); }
		set { Schema.SetString(this.Handle, "CGameText", "m_iszMessage", value); }
	}

	// m_textParms
	[SchemaMember("CGameText", "m_textParms")]
	public hudtextparms_t TextParms => Schema.GetDeclaredClass<hudtextparms_t>(this.Handle, "CGameText", "m_textParms");

}

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

public partial class CMessageEntity : CPointEntity
{
    public CMessageEntity (IntPtr pointer) : base(pointer) {}

	// m_radius
	[SchemaMember("CMessageEntity", "m_radius")]
	public ref Int32 Radius => ref Schema.GetRef<Int32>(this.Handle, "CMessageEntity", "m_radius");

	// m_messageText
	[SchemaMember("CMessageEntity", "m_messageText")]
	public string MessageText
	{
		get { return Schema.GetUtf8String(this.Handle, "CMessageEntity", "m_messageText"); }
		set { Schema.SetString(this.Handle, "CMessageEntity", "m_messageText", value); }
	}

	// m_drawText
	[SchemaMember("CMessageEntity", "m_drawText")]
	public ref bool DrawText => ref Schema.GetRef<bool>(this.Handle, "CMessageEntity", "m_drawText");

	// m_bDeveloperOnly
	[SchemaMember("CMessageEntity", "m_bDeveloperOnly")]
	public ref bool DeveloperOnly => ref Schema.GetRef<bool>(this.Handle, "CMessageEntity", "m_bDeveloperOnly");

	// m_bEnabled
	[SchemaMember("CMessageEntity", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CMessageEntity", "m_bEnabled");

}

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

public partial class CScriptTriggerHurt : CTriggerHurt
{
    public CScriptTriggerHurt (IntPtr pointer) : base(pointer) {}

	// m_vExtent
	[SchemaMember("CScriptTriggerHurt", "m_vExtent")]
	public Vector Extent => Schema.GetDeclaredClass<Vector>(this.Handle, "CScriptTriggerHurt", "m_vExtent");

}

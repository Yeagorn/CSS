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

public partial class CEnvDetailController : CBaseEntity
{
    public CEnvDetailController (IntPtr pointer) : base(pointer) {}

	// m_flFadeStartDist
	[SchemaMember("CEnvDetailController", "m_flFadeStartDist")]
	public ref float FadeStartDist => ref Schema.GetRef<float>(this.Handle, "CEnvDetailController", "m_flFadeStartDist");

	// m_flFadeEndDist
	[SchemaMember("CEnvDetailController", "m_flFadeEndDist")]
	public ref float FadeEndDist => ref Schema.GetRef<float>(this.Handle, "CEnvDetailController", "m_flFadeEndDist");

}

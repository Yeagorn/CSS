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

public partial class CFuncMonitor : CFuncBrush
{
    public CFuncMonitor (IntPtr pointer) : base(pointer) {}

	// m_targetCamera
	[SchemaMember("CFuncMonitor", "m_targetCamera")]
	public string TargetCamera
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMonitor", "m_targetCamera"); }
		set { Schema.SetString(this.Handle, "CFuncMonitor", "m_targetCamera", value); }
	}

	// m_nResolutionEnum
	[SchemaMember("CFuncMonitor", "m_nResolutionEnum")]
	public ref Int32 ResolutionEnum => ref Schema.GetRef<Int32>(this.Handle, "CFuncMonitor", "m_nResolutionEnum");

	// m_bRenderShadows
	[SchemaMember("CFuncMonitor", "m_bRenderShadows")]
	public ref bool RenderShadows => ref Schema.GetRef<bool>(this.Handle, "CFuncMonitor", "m_bRenderShadows");

	// m_bUseUniqueColorTarget
	[SchemaMember("CFuncMonitor", "m_bUseUniqueColorTarget")]
	public ref bool UseUniqueColorTarget => ref Schema.GetRef<bool>(this.Handle, "CFuncMonitor", "m_bUseUniqueColorTarget");

	// m_brushModelName
	[SchemaMember("CFuncMonitor", "m_brushModelName")]
	public string BrushModelName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMonitor", "m_brushModelName"); }
		set { Schema.SetString(this.Handle, "CFuncMonitor", "m_brushModelName", value); }
	}

	// m_hTargetCamera
	[SchemaMember("CFuncMonitor", "m_hTargetCamera")]
	public CHandle<CBaseEntity> HTargetCamera => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CFuncMonitor", "m_hTargetCamera");

	// m_bEnabled
	[SchemaMember("CFuncMonitor", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CFuncMonitor", "m_bEnabled");

	// m_bDraw3DSkybox
	[SchemaMember("CFuncMonitor", "m_bDraw3DSkybox")]
	public ref bool Draw3DSkybox => ref Schema.GetRef<bool>(this.Handle, "CFuncMonitor", "m_bDraw3DSkybox");

	// m_bStartEnabled
	[SchemaMember("CFuncMonitor", "m_bStartEnabled")]
	public ref bool StartEnabled => ref Schema.GetRef<bool>(this.Handle, "CFuncMonitor", "m_bStartEnabled");

}

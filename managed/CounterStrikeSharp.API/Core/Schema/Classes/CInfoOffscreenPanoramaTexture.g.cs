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

public partial class CInfoOffscreenPanoramaTexture : CPointEntity
{
    public CInfoOffscreenPanoramaTexture (IntPtr pointer) : base(pointer) {}

	// m_bDisabled
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_bDisabled");

	// m_nResolutionX
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_nResolutionX")]
	public ref Int32 ResolutionX => ref Schema.GetRef<Int32>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_nResolutionX");

	// m_nResolutionY
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_nResolutionY")]
	public ref Int32 ResolutionY => ref Schema.GetRef<Int32>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_nResolutionY");

	// m_szLayoutFileName
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_szLayoutFileName")]
	public string LayoutFileName
	{
		get { return Schema.GetUtf8String(this.Handle, "CInfoOffscreenPanoramaTexture", "m_szLayoutFileName"); }
		set { Schema.SetString(this.Handle, "CInfoOffscreenPanoramaTexture", "m_szLayoutFileName", value); }
	}

	// m_RenderAttrName
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_RenderAttrName")]
	public string RenderAttrName
	{
		get { return Schema.GetUtf8String(this.Handle, "CInfoOffscreenPanoramaTexture", "m_RenderAttrName"); }
		set { Schema.SetString(this.Handle, "CInfoOffscreenPanoramaTexture", "m_RenderAttrName", value); }
	}

	// m_TargetEntities
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_TargetEntities")]
	public NetworkedVector<CHandle<CBaseModelEntity>> TargetEntities => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseModelEntity>>>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_TargetEntities");

	// m_nTargetChangeCount
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_nTargetChangeCount")]
	public ref Int32 TargetChangeCount => ref Schema.GetRef<Int32>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_nTargetChangeCount");

	// m_vecCSSClasses
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_vecCSSClasses")]
	public NetworkedVector<string> CSSClasses => Schema.GetDeclaredClass<NetworkedVector<string>>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_vecCSSClasses");

	// m_szTargetsName
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_szTargetsName")]
	public string TargetsName
	{
		get { return Schema.GetUtf8String(this.Handle, "CInfoOffscreenPanoramaTexture", "m_szTargetsName"); }
		set { Schema.SetString(this.Handle, "CInfoOffscreenPanoramaTexture", "m_szTargetsName", value); }
	}

	// m_AdditionalTargetEntities
	[SchemaMember("CInfoOffscreenPanoramaTexture", "m_AdditionalTargetEntities")]
	public NetworkedVector<CHandle<CBaseModelEntity>> AdditionalTargetEntities => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseModelEntity>>>(this.Handle, "CInfoOffscreenPanoramaTexture", "m_AdditionalTargetEntities");

}

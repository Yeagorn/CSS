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

public partial class CGradientFog : CBaseEntity
{
    public CGradientFog (IntPtr pointer) : base(pointer) {}

	// m_hGradientFogTexture
	[SchemaMember("CGradientFog", "m_hGradientFogTexture")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> GradientFogTexture => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CGradientFog", "m_hGradientFogTexture");

	// m_flFogStartDistance
	[SchemaMember("CGradientFog", "m_flFogStartDistance")]
	public ref float FogStartDistance => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogStartDistance");

	// m_flFogEndDistance
	[SchemaMember("CGradientFog", "m_flFogEndDistance")]
	public ref float FogEndDistance => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogEndDistance");

	// m_bHeightFogEnabled
	[SchemaMember("CGradientFog", "m_bHeightFogEnabled")]
	public ref bool HeightFogEnabled => ref Schema.GetRef<bool>(this.Handle, "CGradientFog", "m_bHeightFogEnabled");

	// m_flFogStartHeight
	[SchemaMember("CGradientFog", "m_flFogStartHeight")]
	public ref float FogStartHeight => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogStartHeight");

	// m_flFogEndHeight
	[SchemaMember("CGradientFog", "m_flFogEndHeight")]
	public ref float FogEndHeight => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogEndHeight");

	// m_flFarZ
	[SchemaMember("CGradientFog", "m_flFarZ")]
	public ref float FarZ => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFarZ");

	// m_flFogMaxOpacity
	[SchemaMember("CGradientFog", "m_flFogMaxOpacity")]
	public ref float FogMaxOpacity => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogMaxOpacity");

	// m_flFogFalloffExponent
	[SchemaMember("CGradientFog", "m_flFogFalloffExponent")]
	public ref float FogFalloffExponent => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogFalloffExponent");

	// m_flFogVerticalExponent
	[SchemaMember("CGradientFog", "m_flFogVerticalExponent")]
	public ref float FogVerticalExponent => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogVerticalExponent");

	// m_fogColor
	[SchemaMember("CGradientFog", "m_fogColor")]
	public Color FogColor
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CGradientFog", "m_fogColor"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CGradientFog", "m_fogColor", value); }
	}

	// m_flFogStrength
	[SchemaMember("CGradientFog", "m_flFogStrength")]
	public ref float FogStrength => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFogStrength");

	// m_flFadeTime
	[SchemaMember("CGradientFog", "m_flFadeTime")]
	public ref float FadeTime => ref Schema.GetRef<float>(this.Handle, "CGradientFog", "m_flFadeTime");

	// m_bStartDisabled
	[SchemaMember("CGradientFog", "m_bStartDisabled")]
	public ref bool StartDisabled => ref Schema.GetRef<bool>(this.Handle, "CGradientFog", "m_bStartDisabled");

	// m_bIsEnabled
	[SchemaMember("CGradientFog", "m_bIsEnabled")]
	public ref bool IsEnabled => ref Schema.GetRef<bool>(this.Handle, "CGradientFog", "m_bIsEnabled");

	// m_bGradientFogNeedsTextures
	[SchemaMember("CGradientFog", "m_bGradientFogNeedsTextures")]
	public ref bool GradientFogNeedsTextures => ref Schema.GetRef<bool>(this.Handle, "CGradientFog", "m_bGradientFogNeedsTextures");

}

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

public partial class CTextureBasedAnimatable : CBaseModelEntity
{
    public CTextureBasedAnimatable (IntPtr pointer) : base(pointer) {}

	// m_bLoop
	[SchemaMember("CTextureBasedAnimatable", "m_bLoop")]
	public ref bool Loop => ref Schema.GetRef<bool>(this.Handle, "CTextureBasedAnimatable", "m_bLoop");

	// m_flFPS
	[SchemaMember("CTextureBasedAnimatable", "m_flFPS")]
	public ref float FPS => ref Schema.GetRef<float>(this.Handle, "CTextureBasedAnimatable", "m_flFPS");

	// m_hPositionKeys
	[SchemaMember("CTextureBasedAnimatable", "m_hPositionKeys")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> PositionKeys => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CTextureBasedAnimatable", "m_hPositionKeys");

	// m_hRotationKeys
	[SchemaMember("CTextureBasedAnimatable", "m_hRotationKeys")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> RotationKeys => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CTextureBasedAnimatable", "m_hRotationKeys");

	// m_vAnimationBoundsMin
	[SchemaMember("CTextureBasedAnimatable", "m_vAnimationBoundsMin")]
	public Vector AnimationBoundsMin => Schema.GetDeclaredClass<Vector>(this.Handle, "CTextureBasedAnimatable", "m_vAnimationBoundsMin");

	// m_vAnimationBoundsMax
	[SchemaMember("CTextureBasedAnimatable", "m_vAnimationBoundsMax")]
	public Vector AnimationBoundsMax => Schema.GetDeclaredClass<Vector>(this.Handle, "CTextureBasedAnimatable", "m_vAnimationBoundsMax");

	// m_flStartTime
	[SchemaMember("CTextureBasedAnimatable", "m_flStartTime")]
	public ref float StartTime => ref Schema.GetRef<float>(this.Handle, "CTextureBasedAnimatable", "m_flStartTime");

	// m_flStartFrame
	[SchemaMember("CTextureBasedAnimatable", "m_flStartFrame")]
	public ref float StartFrame => ref Schema.GetRef<float>(this.Handle, "CTextureBasedAnimatable", "m_flStartFrame");

}

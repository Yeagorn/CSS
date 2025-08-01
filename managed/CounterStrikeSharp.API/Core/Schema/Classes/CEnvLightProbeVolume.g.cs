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

public partial class CEnvLightProbeVolume : CBaseEntity
{
    public CEnvLightProbeVolume (IntPtr pointer) : base(pointer) {}

	// m_Entity_hLightProbeTexture
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_hLightProbeTexture")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CEnvLightProbeVolume", "m_Entity_hLightProbeTexture");

	// m_Entity_hLightProbeDirectLightIndicesTexture
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightIndicesTexture")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightIndicesTexture => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightIndicesTexture");

	// m_Entity_hLightProbeDirectLightScalarsTexture
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightScalarsTexture")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightScalarsTexture => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightScalarsTexture");

	// m_Entity_hLightProbeDirectLightShadowsTexture
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightShadowsTexture")]
	public CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightShadowsTexture => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeCTextureBase>>(this.Handle, "CEnvLightProbeVolume", "m_Entity_hLightProbeDirectLightShadowsTexture");

	// m_Entity_vBoxMins
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_vBoxMins")]
	public Vector Entity_vBoxMins => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvLightProbeVolume", "m_Entity_vBoxMins");

	// m_Entity_vBoxMaxs
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_vBoxMaxs")]
	public Vector Entity_vBoxMaxs => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvLightProbeVolume", "m_Entity_vBoxMaxs");

	// m_Entity_bMoveable
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_bMoveable")]
	public ref bool Entity_bMoveable => ref Schema.GetRef<bool>(this.Handle, "CEnvLightProbeVolume", "m_Entity_bMoveable");

	// m_Entity_nHandshake
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nHandshake")]
	public ref Int32 Entity_nHandshake => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nHandshake");

	// m_Entity_nPriority
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nPriority")]
	public ref Int32 Entity_nPriority => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nPriority");

	// m_Entity_bStartDisabled
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_bStartDisabled")]
	public ref bool Entity_bStartDisabled => ref Schema.GetRef<bool>(this.Handle, "CEnvLightProbeVolume", "m_Entity_bStartDisabled");

	// m_Entity_nLightProbeSizeX
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeSizeX")]
	public ref Int32 Entity_nLightProbeSizeX => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeSizeX");

	// m_Entity_nLightProbeSizeY
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeSizeY")]
	public ref Int32 Entity_nLightProbeSizeY => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeSizeY");

	// m_Entity_nLightProbeSizeZ
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeSizeZ")]
	public ref Int32 Entity_nLightProbeSizeZ => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeSizeZ");

	// m_Entity_nLightProbeAtlasX
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasX")]
	public ref Int32 Entity_nLightProbeAtlasX => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasX");

	// m_Entity_nLightProbeAtlasY
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasY")]
	public ref Int32 Entity_nLightProbeAtlasY => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasY");

	// m_Entity_nLightProbeAtlasZ
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasZ")]
	public ref Int32 Entity_nLightProbeAtlasZ => ref Schema.GetRef<Int32>(this.Handle, "CEnvLightProbeVolume", "m_Entity_nLightProbeAtlasZ");

	// m_Entity_bEnabled
	[SchemaMember("CEnvLightProbeVolume", "m_Entity_bEnabled")]
	public ref bool Entity_bEnabled => ref Schema.GetRef<bool>(this.Handle, "CEnvLightProbeVolume", "m_Entity_bEnabled");

}

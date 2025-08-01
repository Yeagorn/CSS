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

public partial class CSkeletonInstance : CGameSceneNode
{
    public CSkeletonInstance (IntPtr pointer) : base(pointer) {}

	// m_modelState
	[SchemaMember("CSkeletonInstance", "m_modelState")]
	public CModelState ModelState => Schema.GetDeclaredClass<CModelState>(this.Handle, "CSkeletonInstance", "m_modelState");

	// m_bIsAnimationEnabled
	[SchemaMember("CSkeletonInstance", "m_bIsAnimationEnabled")]
	public ref bool IsAnimationEnabled => ref Schema.GetRef<bool>(this.Handle, "CSkeletonInstance", "m_bIsAnimationEnabled");

	// m_bUseParentRenderBounds
	[SchemaMember("CSkeletonInstance", "m_bUseParentRenderBounds")]
	public ref bool UseParentRenderBounds => ref Schema.GetRef<bool>(this.Handle, "CSkeletonInstance", "m_bUseParentRenderBounds");

	// m_bDisableSolidCollisionsForHierarchy
	[SchemaMember("CSkeletonInstance", "m_bDisableSolidCollisionsForHierarchy")]
	public ref bool DisableSolidCollisionsForHierarchy => ref Schema.GetRef<bool>(this.Handle, "CSkeletonInstance", "m_bDisableSolidCollisionsForHierarchy");

	// m_materialGroup
	[SchemaMember("CSkeletonInstance", "m_materialGroup")]
	public CUtlStringToken MaterialGroup => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CSkeletonInstance", "m_materialGroup");

	// m_nHitboxSet
	[SchemaMember("CSkeletonInstance", "m_nHitboxSet")]
	public ref byte HitboxSet => ref Schema.GetRef<byte>(this.Handle, "CSkeletonInstance", "m_nHitboxSet");

}

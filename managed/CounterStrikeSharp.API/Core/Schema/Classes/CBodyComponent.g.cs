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

public partial class CBodyComponent : CEntityComponent
{
    public CBodyComponent (IntPtr pointer) : base(pointer) {}

	// m_pSceneNode
	[SchemaMember("CBodyComponent", "m_pSceneNode")]
	public CGameSceneNode? SceneNode => Schema.GetPointer<CGameSceneNode>(this.Handle, "CBodyComponent", "m_pSceneNode");

	// __m_pChainEntity
	[SchemaMember("CBodyComponent", "__m_pChainEntity")]
	public CNetworkVarChainer __m_pChainEntity => Schema.GetDeclaredClass<CNetworkVarChainer>(this.Handle, "CBodyComponent", "__m_pChainEntity");

}

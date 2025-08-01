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

public partial class CItemGenericTriggerHelper : CBaseModelEntity
{
    public CItemGenericTriggerHelper (IntPtr pointer) : base(pointer) {}

	// m_hParentItem
	[SchemaMember("CItemGenericTriggerHelper", "m_hParentItem")]
	public CHandle<CItemGeneric> ParentItem => Schema.GetDeclaredClass<CHandle<CItemGeneric>>(this.Handle, "CItemGenericTriggerHelper", "m_hParentItem");

}

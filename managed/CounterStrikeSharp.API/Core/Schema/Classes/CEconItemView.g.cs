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

public partial class CEconItemView : IEconItemInterface
{
    public CEconItemView (IntPtr pointer) : base(pointer) {}

	// m_iItemDefinitionIndex
	[SchemaMember("CEconItemView", "m_iItemDefinitionIndex")]
	public ref UInt16 ItemDefinitionIndex => ref Schema.GetRef<UInt16>(this.Handle, "CEconItemView", "m_iItemDefinitionIndex");

	// m_iEntityQuality
	[SchemaMember("CEconItemView", "m_iEntityQuality")]
	public ref Int32 EntityQuality => ref Schema.GetRef<Int32>(this.Handle, "CEconItemView", "m_iEntityQuality");

	// m_iEntityLevel
	[SchemaMember("CEconItemView", "m_iEntityLevel")]
	public ref UInt32 EntityLevel => ref Schema.GetRef<UInt32>(this.Handle, "CEconItemView", "m_iEntityLevel");

	// m_iItemID
	[SchemaMember("CEconItemView", "m_iItemID")]
	public ref UInt64 ItemID => ref Schema.GetRef<UInt64>(this.Handle, "CEconItemView", "m_iItemID");

	// m_iItemIDHigh
	[SchemaMember("CEconItemView", "m_iItemIDHigh")]
	public ref UInt32 ItemIDHigh => ref Schema.GetRef<UInt32>(this.Handle, "CEconItemView", "m_iItemIDHigh");

	// m_iItemIDLow
	[SchemaMember("CEconItemView", "m_iItemIDLow")]
	public ref UInt32 ItemIDLow => ref Schema.GetRef<UInt32>(this.Handle, "CEconItemView", "m_iItemIDLow");

	// m_iAccountID
	[SchemaMember("CEconItemView", "m_iAccountID")]
	public ref UInt32 AccountID => ref Schema.GetRef<UInt32>(this.Handle, "CEconItemView", "m_iAccountID");

	// m_iInventoryPosition
	[SchemaMember("CEconItemView", "m_iInventoryPosition")]
	public ref UInt32 InventoryPosition => ref Schema.GetRef<UInt32>(this.Handle, "CEconItemView", "m_iInventoryPosition");

	// m_bInitialized
	[SchemaMember("CEconItemView", "m_bInitialized")]
	public ref bool Initialized => ref Schema.GetRef<bool>(this.Handle, "CEconItemView", "m_bInitialized");

	// m_AttributeList
	[SchemaMember("CEconItemView", "m_AttributeList")]
	public CAttributeList AttributeList => Schema.GetDeclaredClass<CAttributeList>(this.Handle, "CEconItemView", "m_AttributeList");

	// m_NetworkedDynamicAttributes
	[SchemaMember("CEconItemView", "m_NetworkedDynamicAttributes")]
	public CAttributeList NetworkedDynamicAttributes => Schema.GetDeclaredClass<CAttributeList>(this.Handle, "CEconItemView", "m_NetworkedDynamicAttributes");

	// m_szCustomName
	[SchemaMember("CEconItemView", "m_szCustomName")]
	public string CustomName
	{
		get { return Schema.GetString(this.Handle, "CEconItemView", "m_szCustomName"); }
		set { Schema.SetStringBytes(this.Handle, "CEconItemView", "m_szCustomName", value, 161); }
	}

	// m_szCustomNameOverride
	[SchemaMember("CEconItemView", "m_szCustomNameOverride")]
	public string CustomNameOverride
	{
		get { return Schema.GetString(this.Handle, "CEconItemView", "m_szCustomNameOverride"); }
		set { Schema.SetStringBytes(this.Handle, "CEconItemView", "m_szCustomNameOverride", value, 161); }
	}

}

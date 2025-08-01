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

public partial class WeaponPurchaseTracker_t : NativeObject
{
    public WeaponPurchaseTracker_t (IntPtr pointer) : base(pointer) {}

	// m_weaponPurchases
	[SchemaMember("WeaponPurchaseTracker_t", "m_weaponPurchases")]
	public NetworkedVector<WeaponPurchaseCount_t> WeaponPurchases => Schema.GetDeclaredClass<NetworkedVector<WeaponPurchaseCount_t>>(this.Handle, "WeaponPurchaseTracker_t", "m_weaponPurchases");

}

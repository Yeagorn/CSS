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

public partial class CCSPlayer_ActionTrackingServices : CPlayerPawnComponent
{
    public CCSPlayer_ActionTrackingServices (IntPtr pointer) : base(pointer) {}

	// m_hLastWeaponBeforeC4AutoSwitch
	[SchemaMember("CCSPlayer_ActionTrackingServices", "m_hLastWeaponBeforeC4AutoSwitch")]
	public CHandle<CBasePlayerWeapon> LastWeaponBeforeC4AutoSwitch => Schema.GetDeclaredClass<CHandle<CBasePlayerWeapon>>(this.Handle, "CCSPlayer_ActionTrackingServices", "m_hLastWeaponBeforeC4AutoSwitch");

	// m_bIsRescuing
	[SchemaMember("CCSPlayer_ActionTrackingServices", "m_bIsRescuing")]
	public ref bool IsRescuing => ref Schema.GetRef<bool>(this.Handle, "CCSPlayer_ActionTrackingServices", "m_bIsRescuing");

	// m_weaponPurchasesThisMatch
	[SchemaMember("CCSPlayer_ActionTrackingServices", "m_weaponPurchasesThisMatch")]
	public WeaponPurchaseTracker_t WeaponPurchasesThisMatch => Schema.GetDeclaredClass<WeaponPurchaseTracker_t>(this.Handle, "CCSPlayer_ActionTrackingServices", "m_weaponPurchasesThisMatch");

	// m_weaponPurchasesThisRound
	[SchemaMember("CCSPlayer_ActionTrackingServices", "m_weaponPurchasesThisRound")]
	public WeaponPurchaseTracker_t WeaponPurchasesThisRound => Schema.GetDeclaredClass<WeaponPurchaseTracker_t>(this.Handle, "CCSPlayer_ActionTrackingServices", "m_weaponPurchasesThisRound");

}

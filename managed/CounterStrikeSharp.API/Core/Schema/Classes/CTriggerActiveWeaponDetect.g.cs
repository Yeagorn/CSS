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

public partial class CTriggerActiveWeaponDetect : CBaseTrigger
{
    public CTriggerActiveWeaponDetect (IntPtr pointer) : base(pointer) {}

	// m_OnTouchedActiveWeapon
	[SchemaMember("CTriggerActiveWeaponDetect", "m_OnTouchedActiveWeapon")]
	public CEntityIOOutput OnTouchedActiveWeapon => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerActiveWeaponDetect", "m_OnTouchedActiveWeapon");

	// m_iszWeaponClassName
	[SchemaMember("CTriggerActiveWeaponDetect", "m_iszWeaponClassName")]
	public string WeaponClassName
	{
		get { return Schema.GetUtf8String(this.Handle, "CTriggerActiveWeaponDetect", "m_iszWeaponClassName"); }
		set { Schema.SetString(this.Handle, "CTriggerActiveWeaponDetect", "m_iszWeaponClassName", value); }
	}

}

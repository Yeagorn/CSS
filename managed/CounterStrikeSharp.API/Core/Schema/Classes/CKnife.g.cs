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

public partial class CKnife : CCSWeaponBase
{
    public CKnife (IntPtr pointer) : base(pointer) {}

	// m_bFirstAttack
	[SchemaMember("CKnife", "m_bFirstAttack")]
	public ref bool FirstAttack => ref Schema.GetRef<bool>(this.Handle, "CKnife", "m_bFirstAttack");

}

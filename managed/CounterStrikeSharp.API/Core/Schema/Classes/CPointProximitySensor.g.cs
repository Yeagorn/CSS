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

public partial class CPointProximitySensor : CPointEntity
{
    public CPointProximitySensor (IntPtr pointer) : base(pointer) {}

	// m_bDisabled
	[SchemaMember("CPointProximitySensor", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CPointProximitySensor", "m_bDisabled");

	// m_hTargetEntity
	[SchemaMember("CPointProximitySensor", "m_hTargetEntity")]
	public CHandle<CBaseEntity> TargetEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointProximitySensor", "m_hTargetEntity");

}

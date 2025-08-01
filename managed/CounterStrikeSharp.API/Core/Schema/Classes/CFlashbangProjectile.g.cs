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

public partial class CFlashbangProjectile : CBaseCSGrenadeProjectile
{
    public CFlashbangProjectile (IntPtr pointer) : base(pointer) {}

	// m_flTimeToDetonate
	[SchemaMember("CFlashbangProjectile", "m_flTimeToDetonate")]
	public ref float TimeToDetonate => ref Schema.GetRef<float>(this.Handle, "CFlashbangProjectile", "m_flTimeToDetonate");

	// m_numOpponentsHit
	[SchemaMember("CFlashbangProjectile", "m_numOpponentsHit")]
	public ref byte NumOpponentsHit => ref Schema.GetRef<byte>(this.Handle, "CFlashbangProjectile", "m_numOpponentsHit");

	// m_numTeammatesHit
	[SchemaMember("CFlashbangProjectile", "m_numTeammatesHit")]
	public ref byte NumTeammatesHit => ref Schema.GetRef<byte>(this.Handle, "CFlashbangProjectile", "m_numTeammatesHit");

}

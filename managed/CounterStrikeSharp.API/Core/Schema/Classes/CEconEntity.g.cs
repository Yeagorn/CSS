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

public partial class CEconEntity : CBaseFlex
{
    public CEconEntity (IntPtr pointer) : base(pointer) {}

	// m_AttributeManager
	[SchemaMember("CEconEntity", "m_AttributeManager")]
	public CAttributeContainer AttributeManager => Schema.GetDeclaredClass<CAttributeContainer>(this.Handle, "CEconEntity", "m_AttributeManager");

	// m_OriginalOwnerXuidLow
	[SchemaMember("CEconEntity", "m_OriginalOwnerXuidLow")]
	public ref UInt32 OriginalOwnerXuidLow => ref Schema.GetRef<UInt32>(this.Handle, "CEconEntity", "m_OriginalOwnerXuidLow");

	// m_OriginalOwnerXuidHigh
	[SchemaMember("CEconEntity", "m_OriginalOwnerXuidHigh")]
	public ref UInt32 OriginalOwnerXuidHigh => ref Schema.GetRef<UInt32>(this.Handle, "CEconEntity", "m_OriginalOwnerXuidHigh");

	// m_nFallbackPaintKit
	[SchemaMember("CEconEntity", "m_nFallbackPaintKit")]
	public ref Int32 FallbackPaintKit => ref Schema.GetRef<Int32>(this.Handle, "CEconEntity", "m_nFallbackPaintKit");

	// m_nFallbackSeed
	[SchemaMember("CEconEntity", "m_nFallbackSeed")]
	public ref Int32 FallbackSeed => ref Schema.GetRef<Int32>(this.Handle, "CEconEntity", "m_nFallbackSeed");

	// m_flFallbackWear
	[SchemaMember("CEconEntity", "m_flFallbackWear")]
	public ref float FallbackWear => ref Schema.GetRef<float>(this.Handle, "CEconEntity", "m_flFallbackWear");

	// m_nFallbackStatTrak
	[SchemaMember("CEconEntity", "m_nFallbackStatTrak")]
	public ref Int32 FallbackStatTrak => ref Schema.GetRef<Int32>(this.Handle, "CEconEntity", "m_nFallbackStatTrak");

	// m_hOldProvidee
	[SchemaMember("CEconEntity", "m_hOldProvidee")]
	public CHandle<CBaseEntity> OldProvidee => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CEconEntity", "m_hOldProvidee");

	// m_iOldOwnerClass
	[SchemaMember("CEconEntity", "m_iOldOwnerClass")]
	public ref Int32 OldOwnerClass => ref Schema.GetRef<Int32>(this.Handle, "CEconEntity", "m_iOldOwnerClass");

}

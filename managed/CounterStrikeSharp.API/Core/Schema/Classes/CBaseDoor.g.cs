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

public partial class CBaseDoor : CBaseToggle
{
    public CBaseDoor (IntPtr pointer) : base(pointer) {}

	// m_angMoveEntitySpace
	[SchemaMember("CBaseDoor", "m_angMoveEntitySpace")]
	public QAngle MoveEntitySpace => Schema.GetDeclaredClass<QAngle>(this.Handle, "CBaseDoor", "m_angMoveEntitySpace");

	// m_vecMoveDirParentSpace
	[SchemaMember("CBaseDoor", "m_vecMoveDirParentSpace")]
	public Vector MoveDirParentSpace => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseDoor", "m_vecMoveDirParentSpace");

	// m_ls
	[SchemaMember("CBaseDoor", "m_ls")]
	public locksound_t Ls => Schema.GetDeclaredClass<locksound_t>(this.Handle, "CBaseDoor", "m_ls");

	// m_bForceClosed
	[SchemaMember("CBaseDoor", "m_bForceClosed")]
	public ref bool ForceClosed => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bForceClosed");

	// m_bDoorGroup
	[SchemaMember("CBaseDoor", "m_bDoorGroup")]
	public ref bool DoorGroup => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bDoorGroup");

	// m_bLocked
	[SchemaMember("CBaseDoor", "m_bLocked")]
	public ref bool Locked => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bLocked");

	// m_bIgnoreDebris
	[SchemaMember("CBaseDoor", "m_bIgnoreDebris")]
	public ref bool IgnoreDebris => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bIgnoreDebris");

	// m_eSpawnPosition
	[SchemaMember("CBaseDoor", "m_eSpawnPosition")]
	public ref FuncDoorSpawnPos_t SpawnPosition => ref Schema.GetRef<FuncDoorSpawnPos_t>(this.Handle, "CBaseDoor", "m_eSpawnPosition");

	// m_flBlockDamage
	[SchemaMember("CBaseDoor", "m_flBlockDamage")]
	public ref float BlockDamage => ref Schema.GetRef<float>(this.Handle, "CBaseDoor", "m_flBlockDamage");

	// m_NoiseMoving
	[SchemaMember("CBaseDoor", "m_NoiseMoving")]
	public string NoiseMoving
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDoor", "m_NoiseMoving"); }
		set { Schema.SetString(this.Handle, "CBaseDoor", "m_NoiseMoving", value); }
	}

	// m_NoiseArrived
	[SchemaMember("CBaseDoor", "m_NoiseArrived")]
	public string NoiseArrived
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDoor", "m_NoiseArrived"); }
		set { Schema.SetString(this.Handle, "CBaseDoor", "m_NoiseArrived", value); }
	}

	// m_NoiseMovingClosed
	[SchemaMember("CBaseDoor", "m_NoiseMovingClosed")]
	public string NoiseMovingClosed
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDoor", "m_NoiseMovingClosed"); }
		set { Schema.SetString(this.Handle, "CBaseDoor", "m_NoiseMovingClosed", value); }
	}

	// m_NoiseArrivedClosed
	[SchemaMember("CBaseDoor", "m_NoiseArrivedClosed")]
	public string NoiseArrivedClosed
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDoor", "m_NoiseArrivedClosed"); }
		set { Schema.SetString(this.Handle, "CBaseDoor", "m_NoiseArrivedClosed", value); }
	}

	// m_ChainTarget
	[SchemaMember("CBaseDoor", "m_ChainTarget")]
	public string ChainTarget
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDoor", "m_ChainTarget"); }
		set { Schema.SetString(this.Handle, "CBaseDoor", "m_ChainTarget", value); }
	}

	// m_OnBlockedClosing
	[SchemaMember("CBaseDoor", "m_OnBlockedClosing")]
	public CEntityIOOutput OnBlockedClosing => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnBlockedClosing");

	// m_OnBlockedOpening
	[SchemaMember("CBaseDoor", "m_OnBlockedOpening")]
	public CEntityIOOutput OnBlockedOpening => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnBlockedOpening");

	// m_OnUnblockedClosing
	[SchemaMember("CBaseDoor", "m_OnUnblockedClosing")]
	public CEntityIOOutput OnUnblockedClosing => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnUnblockedClosing");

	// m_OnUnblockedOpening
	[SchemaMember("CBaseDoor", "m_OnUnblockedOpening")]
	public CEntityIOOutput OnUnblockedOpening => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnUnblockedOpening");

	// m_OnFullyClosed
	[SchemaMember("CBaseDoor", "m_OnFullyClosed")]
	public CEntityIOOutput OnFullyClosed => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnFullyClosed");

	// m_OnFullyOpen
	[SchemaMember("CBaseDoor", "m_OnFullyOpen")]
	public CEntityIOOutput OnFullyOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnFullyOpen");

	// m_OnClose
	[SchemaMember("CBaseDoor", "m_OnClose")]
	public CEntityIOOutput OnClose => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnClose");

	// m_OnOpen
	[SchemaMember("CBaseDoor", "m_OnOpen")]
	public CEntityIOOutput OnOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnOpen");

	// m_OnLockedUse
	[SchemaMember("CBaseDoor", "m_OnLockedUse")]
	public CEntityIOOutput OnLockedUse => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseDoor", "m_OnLockedUse");

	// m_bLoopMoveSound
	[SchemaMember("CBaseDoor", "m_bLoopMoveSound")]
	public ref bool LoopMoveSound => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bLoopMoveSound");

	// m_bCreateNavObstacle
	[SchemaMember("CBaseDoor", "m_bCreateNavObstacle")]
	public ref bool CreateNavObstacle => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bCreateNavObstacle");

	// m_isChaining
	[SchemaMember("CBaseDoor", "m_isChaining")]
	public ref bool IsChaining => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_isChaining");

	// m_bIsUsable
	[SchemaMember("CBaseDoor", "m_bIsUsable")]
	public ref bool IsUsable => ref Schema.GetRef<bool>(this.Handle, "CBaseDoor", "m_bIsUsable");

}

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

public partial class CCollisionProperty : NativeObject
{
    public CCollisionProperty (IntPtr pointer) : base(pointer) {}

	// m_collisionAttribute
	[SchemaMember("CCollisionProperty", "m_collisionAttribute")]
	public VPhysicsCollisionAttribute_t CollisionAttribute => Schema.GetDeclaredClass<VPhysicsCollisionAttribute_t>(this.Handle, "CCollisionProperty", "m_collisionAttribute");

	// m_vecMins
	[SchemaMember("CCollisionProperty", "m_vecMins")]
	public Vector Mins => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecMins");

	// m_vecMaxs
	[SchemaMember("CCollisionProperty", "m_vecMaxs")]
	public Vector Maxs => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecMaxs");

	// m_usSolidFlags
	[SchemaMember("CCollisionProperty", "m_usSolidFlags")]
	public ref byte SolidFlags => ref Schema.GetRef<byte>(this.Handle, "CCollisionProperty", "m_usSolidFlags");

	// m_nSolidType
	[SchemaMember("CCollisionProperty", "m_nSolidType")]
	public ref SolidType_t SolidType => ref Schema.GetRef<SolidType_t>(this.Handle, "CCollisionProperty", "m_nSolidType");

	// m_triggerBloat
	[SchemaMember("CCollisionProperty", "m_triggerBloat")]
	public ref byte TriggerBloat => ref Schema.GetRef<byte>(this.Handle, "CCollisionProperty", "m_triggerBloat");

	// m_nSurroundType
	[SchemaMember("CCollisionProperty", "m_nSurroundType")]
	public ref SurroundingBoundsType_t SurroundType => ref Schema.GetRef<SurroundingBoundsType_t>(this.Handle, "CCollisionProperty", "m_nSurroundType");

	// m_CollisionGroup
	[SchemaMember("CCollisionProperty", "m_CollisionGroup")]
	public ref byte CollisionGroup => ref Schema.GetRef<byte>(this.Handle, "CCollisionProperty", "m_CollisionGroup");

	// m_nEnablePhysics
	[SchemaMember("CCollisionProperty", "m_nEnablePhysics")]
	public ref byte EnablePhysics => ref Schema.GetRef<byte>(this.Handle, "CCollisionProperty", "m_nEnablePhysics");

	// m_flBoundingRadius
	[SchemaMember("CCollisionProperty", "m_flBoundingRadius")]
	public ref float BoundingRadius => ref Schema.GetRef<float>(this.Handle, "CCollisionProperty", "m_flBoundingRadius");

	// m_vecSpecifiedSurroundingMins
	[SchemaMember("CCollisionProperty", "m_vecSpecifiedSurroundingMins")]
	public Vector SpecifiedSurroundingMins => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecSpecifiedSurroundingMins");

	// m_vecSpecifiedSurroundingMaxs
	[SchemaMember("CCollisionProperty", "m_vecSpecifiedSurroundingMaxs")]
	public Vector SpecifiedSurroundingMaxs => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecSpecifiedSurroundingMaxs");

	// m_vecSurroundingMaxs
	[SchemaMember("CCollisionProperty", "m_vecSurroundingMaxs")]
	public Vector SurroundingMaxs => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecSurroundingMaxs");

	// m_vecSurroundingMins
	[SchemaMember("CCollisionProperty", "m_vecSurroundingMins")]
	public Vector SurroundingMins => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vecSurroundingMins");

	// m_vCapsuleCenter1
	[SchemaMember("CCollisionProperty", "m_vCapsuleCenter1")]
	public Vector CapsuleCenter1 => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vCapsuleCenter1");

	// m_vCapsuleCenter2
	[SchemaMember("CCollisionProperty", "m_vCapsuleCenter2")]
	public Vector CapsuleCenter2 => Schema.GetDeclaredClass<Vector>(this.Handle, "CCollisionProperty", "m_vCapsuleCenter2");

	// m_flCapsuleRadius
	[SchemaMember("CCollisionProperty", "m_flCapsuleRadius")]
	public ref float CapsuleRadius => ref Schema.GetRef<float>(this.Handle, "CCollisionProperty", "m_flCapsuleRadius");

}

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

public partial class CBuoyancyHelper : NativeObject
{
    public CBuoyancyHelper (IntPtr pointer) : base(pointer) {}

	// m_nFluidType
	[SchemaMember("CBuoyancyHelper", "m_nFluidType")]
	public CUtlStringToken FluidType => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CBuoyancyHelper", "m_nFluidType");

	// m_flFluidDensity
	[SchemaMember("CBuoyancyHelper", "m_flFluidDensity")]
	public ref float FluidDensity => ref Schema.GetRef<float>(this.Handle, "CBuoyancyHelper", "m_flFluidDensity");

	// m_vecFractionOfWheelSubmergedForWheelFriction
	[SchemaMember("CBuoyancyHelper", "m_vecFractionOfWheelSubmergedForWheelFriction")]
	public NetworkedVector<float> FractionOfWheelSubmergedForWheelFriction => Schema.GetDeclaredClass<NetworkedVector<float>>(this.Handle, "CBuoyancyHelper", "m_vecFractionOfWheelSubmergedForWheelFriction");

	// m_vecWheelFrictionScales
	[SchemaMember("CBuoyancyHelper", "m_vecWheelFrictionScales")]
	public NetworkedVector<float> WheelFrictionScales => Schema.GetDeclaredClass<NetworkedVector<float>>(this.Handle, "CBuoyancyHelper", "m_vecWheelFrictionScales");

	// m_vecFractionOfWheelSubmergedForWheelDrag
	[SchemaMember("CBuoyancyHelper", "m_vecFractionOfWheelSubmergedForWheelDrag")]
	public NetworkedVector<float> FractionOfWheelSubmergedForWheelDrag => Schema.GetDeclaredClass<NetworkedVector<float>>(this.Handle, "CBuoyancyHelper", "m_vecFractionOfWheelSubmergedForWheelDrag");

	// m_vecWheelDrag
	[SchemaMember("CBuoyancyHelper", "m_vecWheelDrag")]
	public NetworkedVector<float> WheelDrag => Schema.GetDeclaredClass<NetworkedVector<float>>(this.Handle, "CBuoyancyHelper", "m_vecWheelDrag");

}

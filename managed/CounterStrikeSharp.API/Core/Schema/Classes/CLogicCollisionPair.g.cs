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

public partial class CLogicCollisionPair : CLogicalEntity
{
    public CLogicCollisionPair (IntPtr pointer) : base(pointer) {}

	// m_nameAttach1
	[SchemaMember("CLogicCollisionPair", "m_nameAttach1")]
	public string NameAttach1
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicCollisionPair", "m_nameAttach1"); }
		set { Schema.SetString(this.Handle, "CLogicCollisionPair", "m_nameAttach1", value); }
	}

	// m_nameAttach2
	[SchemaMember("CLogicCollisionPair", "m_nameAttach2")]
	public string NameAttach2
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicCollisionPair", "m_nameAttach2"); }
		set { Schema.SetString(this.Handle, "CLogicCollisionPair", "m_nameAttach2", value); }
	}

	// m_supportMultipleEntitiesWithSameName
	[SchemaMember("CLogicCollisionPair", "m_supportMultipleEntitiesWithSameName")]
	public ref bool SupportMultipleEntitiesWithSameName => ref Schema.GetRef<bool>(this.Handle, "CLogicCollisionPair", "m_supportMultipleEntitiesWithSameName");

	// m_disabled
	[SchemaMember("CLogicCollisionPair", "m_disabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CLogicCollisionPair", "m_disabled");

	// m_succeeded
	[SchemaMember("CLogicCollisionPair", "m_succeeded")]
	public ref bool Succeeded => ref Schema.GetRef<bool>(this.Handle, "CLogicCollisionPair", "m_succeeded");

}

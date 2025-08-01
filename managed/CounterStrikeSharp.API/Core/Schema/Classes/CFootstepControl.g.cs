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

public partial class CFootstepControl : CBaseTrigger
{
    public CFootstepControl (IntPtr pointer) : base(pointer) {}

	// m_source
	[SchemaMember("CFootstepControl", "m_source")]
	public string Source
	{
		get { return Schema.GetUtf8String(this.Handle, "CFootstepControl", "m_source"); }
		set { Schema.SetString(this.Handle, "CFootstepControl", "m_source", value); }
	}

	// m_destination
	[SchemaMember("CFootstepControl", "m_destination")]
	public string Destination
	{
		get { return Schema.GetUtf8String(this.Handle, "CFootstepControl", "m_destination"); }
		set { Schema.SetString(this.Handle, "CFootstepControl", "m_destination", value); }
	}

}

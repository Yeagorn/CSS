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

public partial class CFilterModel : CBaseFilter
{
    public CFilterModel (IntPtr pointer) : base(pointer) {}

	// m_iFilterModel
	[SchemaMember("CFilterModel", "m_iFilterModel")]
	public string FilterModel
	{
		get { return Schema.GetUtf8String(this.Handle, "CFilterModel", "m_iFilterModel"); }
		set { Schema.SetString(this.Handle, "CFilterModel", "m_iFilterModel", value); }
	}

}

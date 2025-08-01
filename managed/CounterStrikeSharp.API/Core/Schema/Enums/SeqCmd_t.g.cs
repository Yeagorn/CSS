// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;

namespace CounterStrikeSharp.API.Core;

public enum SeqCmd_t : uint
{
	SeqCmd_Nop = 0x0,
	SeqCmd_LinearDelta = 0x1,
	SeqCmd_FetchFrameRange = 0x2,
	SeqCmd_Slerp = 0x3,
	SeqCmd_Add = 0x4,
	SeqCmd_Subtract = 0x5,
	SeqCmd_Scale = 0x6,
	SeqCmd_Copy = 0x7,
	SeqCmd_Blend = 0x8,
	SeqCmd_Worldspace = 0x9,
	SeqCmd_Sequence = 0xA,
	SeqCmd_FetchCycle = 0xB,
	SeqCmd_FetchFrame = 0xC,
	SeqCmd_IKLockInPlace = 0xD,
	SeqCmd_IKRestoreAll = 0xE,
	SeqCmd_ReverseSequence = 0xF,
	SeqCmd_Transform = 0x10,
}

﻿using System.Runtime.InteropServices;

namespace WRAM.Snes9x.Models.Structs
{
	/// <summary>Snes9x savestate header</summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1, Size = 14)]
	public struct Header
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public char[] Signature;
		public char Colon;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public char[] Version;
		public char LineFeed;
	}
}

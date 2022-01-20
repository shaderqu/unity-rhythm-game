// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatServer
{
	public class GetProtectMessageOutputLengthOptions
	{
		/// <summary>
		/// Length in bytes of input
		/// </summary>
		public uint DataLengthBytes { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetProtectMessageOutputLengthOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_DataLengthBytes;

		public uint DataLengthBytes
		{
			set
			{
				m_DataLengthBytes = value;
			}
		}

		public void Set(GetProtectMessageOutputLengthOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatServerInterface.GetprotectmessageoutputlengthApiLatest;
				DataLengthBytes = other.DataLengthBytes;
			}
		}

		public void Set(object other)
		{
			Set(other as GetProtectMessageOutputLengthOptions);
		}

		public void Dispose()
		{
		}
	}
}
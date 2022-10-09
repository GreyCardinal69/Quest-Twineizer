using System;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct FactionFilterSerializable
	{
		public FactionFilterType Type;

		public int[] List;
	}
}
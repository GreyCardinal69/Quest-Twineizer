using System;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct LootItemSerializable
	{
		public float Weight;

		public LootContentSerializable Loot;
	}
}
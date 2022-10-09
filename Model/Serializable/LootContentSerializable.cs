using System;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct LootContentSerializable
	{
		public LootItemType Type;

		public int ItemId;

		public int MinAmount;

		public int MaxAmount;

		public float ValueRatio;

		public FactionFilterSerializable Factions;

		public LootItemSerializable[] Items;
	}
}
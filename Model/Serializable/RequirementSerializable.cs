using System;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct RequirementSerializable
	{
		public RequirementType Type;

		public int ItemId;

		public int MinValue;

		public int MaxValue;

		public int Character;

		public int Faction;

		public LootContentSerializable Loot;

		public RequirementSerializable[] Requirements;
	}
}
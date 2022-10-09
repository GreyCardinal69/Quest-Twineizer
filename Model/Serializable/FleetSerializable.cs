using System;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class FleetSerializable : SerializableItem
	{
		public FactionFilterSerializable Factions;

		public int LevelBonus;

		public bool NoRandomShips;

		public int CombatTimeLimit;

		public RewardCondition LootCondition;

		public RewardCondition ExpCondition;

		public int[] SpecificShips;
	}
}
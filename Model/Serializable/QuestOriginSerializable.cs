using System;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct QuestOriginSerializable
	{
		public QuestOriginType Type;

		public FactionFilterSerializable Factions;

		public int MinDistance;

		public int MaxDistance;

		public int MinRelations;

		public int MaxRelations;
	}
}
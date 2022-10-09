namespace EditorDatabase.Enums
{
	public enum RequirementType
	{
		Empty,
		Any,
		All,
		None,
		PlayerPosition = 6,
		RandomStarSystem,
		AggressiveOccupants,
		QuestCompleted,
		QuestActive,
		CharacterRelations = 15,
		FactionRelations,
		StarbaseCaptured,
		Faction = 20,
		HaveQuestItem = 25,
		HaveItem,
		HaveItemById,
		ComeToOrigin = 30,
		TimeSinceQuestStart = 40,
		TimeSinceLastCompletion
	}
}
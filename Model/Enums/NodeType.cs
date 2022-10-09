namespace EditorDatabase.Enums
{
	public enum NodeType
	{
		Undefined,
		ComingSoon,
		ShowDialog = 10,
		OpenShipyard,
		Switch = 15,
		Random,
		Condition,
		AttackFleet = 20,
		AttackOccupants,
		DestroyOccupants = 25,
		SuppressOccupants,
		Retreat = 30,
		ReceiveItem = 35,
		RemoveItem,
		Trade,
		CompleteQuest = 40,
		FailQuest,
		CancelQuest,
		StartQuest,
		SetCharacterRelations = 50,
		SetFactionRelations,
		ChangeCharacterRelations = 55,
		ChangeFactionRelations,
		CaptureStarBase = 60,
		LiberateStarBase,
		ChangeFaction
	}
}
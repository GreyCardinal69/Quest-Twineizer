using System;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class LootSerializable : SerializableItem
	{
		public LootContentSerializable Loot;
	}
}
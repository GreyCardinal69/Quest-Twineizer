using System;
using System.ComponentModel;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class CharacterSerializable : SerializableItem
	{
		[DefaultValue("")]
		public string Name;

		[DefaultValue("")]
		public string AvatarIcon;

		public int Faction;

		public int Inventory;

		public int Fleet;

		public int Relations;

		public bool IsUnique;
	}
}
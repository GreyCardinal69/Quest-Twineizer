using System;
using System.ComponentModel;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class QuestItemSerializable : SerializableItem
	{
		[DefaultValue("")]
		public string Name;

		[DefaultValue("")]
		public string Description;

		[DefaultValue("")]
		public string Icon;

		[DefaultValue("")]
		public string Color;

		public int Price;
	}
}
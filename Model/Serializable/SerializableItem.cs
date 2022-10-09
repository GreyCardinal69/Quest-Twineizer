using System;
using EditorDatabase.Enums;
using Newtonsoft.Json;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class SerializableItem
	{
		[JsonIgnore]
		public string FileName { get; set; }

		public ItemType ItemType;

		public int Id;

		public bool Disabled;
	}
}
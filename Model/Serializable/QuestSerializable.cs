using System;
using System.ComponentModel;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class QuestSerializable : SerializableItem
	{
		[DefaultValue("")]
		public string Name;

		public QuestType QuestType;

		public StartCondition StartCondition;

		public float Weight;

		public QuestOriginSerializable Origin;

		public RequirementSerializable Requirement;

		public int Level;

		public NodeSerializable[] Nodes;
	}
}
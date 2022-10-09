using System;
using System.ComponentModel;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct NodeSerializable
	{
		public int Id;

		public NodeType Type;

		public RequiredViewMode RequiredView;

		[DefaultValue("")]
		public string Message;

		public int DefaultTransition;

		public int FailureTransition;

		public int Enemy;

		public int Loot;

		public int Quest;

		public int Character;

		public int Faction;

		public int Value;

		public NodeActionSerializable[] Actions;

		public NodeTransitionSerializable[] Transitions;
	}
}
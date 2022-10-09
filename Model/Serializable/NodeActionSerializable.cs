using System;
using System.ComponentModel;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct NodeActionSerializable
	{
		public int TargetNode;

		public RequirementSerializable Requirement;

		[DefaultValue("")]
		public string ButtonText;
	}
}
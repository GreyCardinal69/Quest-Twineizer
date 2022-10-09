using System;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public struct NodeTransitionSerializable
	{
		public int TargetNode;

		public RequirementSerializable Requirement;

		public float Weight;
	}
}
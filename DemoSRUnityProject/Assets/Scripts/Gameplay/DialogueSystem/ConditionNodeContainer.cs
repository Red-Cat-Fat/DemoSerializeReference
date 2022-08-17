using System;
using Gameplay.Conditions;
using UnityEngine;

namespace Gameplay.DialogueSystem
{
	[Serializable]
	public class ConditionNodeContainer
	{
		[SR(typeof(ICondition))]
		[SerializeReference]
		public ICondition Condition = new AlwaysTrueCondition();
		[SR(typeof(INode))]
		[SerializeReference]
		public INode Node;
	}
}
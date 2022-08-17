using System;
using Gameplay.Conditions;
using Gameplay.GameplayActions;
using UnityEngine;

namespace Gameplay.Components
{
	[Serializable]
	public class ActionContainer
	{
		[SR(typeof(ICondition))]
		[SerializeReference]
		public ICondition Condition;
		[SR(typeof(IGamePlayAction))]
		[SerializeReference]
		public IGamePlayAction GamePlayAction;
	}
	
}
using System;
using Gameplay.DialogueSystem;
using UnityEngine;

namespace Gameplay.GameplayActions
{
	[Serializable]
	public class StartDialogueAction : IGamePlayAction
	{
		[SR(typeof(INode))]
		[SerializeReference]
		public INode Node;
		
		public void Apply(GameState gameState, GameObject source)
		{
			Node.Apply(gameState, source);
		}
	}
}
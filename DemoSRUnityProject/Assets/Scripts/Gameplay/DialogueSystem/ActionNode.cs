using Gameplay.GameplayActions;
using UnityEngine;

namespace Gameplay.DialogueSystem
{
	public class ActionNode : INode
	{
		public string TitleNode
			=> TitleVariant;
		public string TitleVariant;
		
		[SR(typeof(IGamePlayAction))]
		[SerializeReference]
		public IGamePlayAction GamePlayAction;
		[SR(typeof(INode))]
		[SerializeReference]
		public INode NextNode;
		
		public void Apply(GameState gameState, GameObject source)
		{
			GamePlayAction?.Apply(gameState, source);
			NextNode?.Apply(gameState, source);
			if(NextNode == null)
				gameState.CloseAllWindow();
		}
	}
}
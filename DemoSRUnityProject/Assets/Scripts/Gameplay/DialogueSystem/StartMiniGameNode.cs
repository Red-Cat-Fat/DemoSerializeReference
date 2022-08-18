using System;
using Gameplay.DialogueSystem.Components;
using UnityEngine;

namespace Gameplay.DialogueSystem
{
	[Serializable]
	public class StartMiniGameNode : INode
	{
		public string TitleNode
			=> SelectTitle;

		public string SelectTitle;
		public GameObject WindowPrefab;
		
		public int TargetValue;
		[SR(typeof(INode))]
		[SerializeReference]
		public INode WinNode;
		[SR(typeof(INode))]
		[SerializeReference]
		public INode LoseNode;

		public void Apply(GameState gameState, GameObject source)
		{
			
			var window = gameState.OpenWindow(WindowPrefab);
			if (window is MiniGameWindow miniGameWindow)
				miniGameWindow.SetData(this, gameState, source);
			else
				gameState.CloseAllWindow();
		}
	}
}
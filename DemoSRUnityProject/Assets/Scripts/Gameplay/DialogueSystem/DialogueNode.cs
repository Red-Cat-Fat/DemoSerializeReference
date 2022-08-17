using System;
using System.Collections.Generic;
using Gameplay.DialogueSystem.Components;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Gameplay.DialogueSystem
{
	[Serializable]
	public class DialogueNode : INode
	{
		public string TitleNode
			=> SelectNodeText;

		public string SelectNodeText;
		public string TextContain;
		public GameObject WindowPrefab;
		public List<ConditionNodeContainer> NextNodes;

		public void Apply(GameState gameState, GameObject source)
		{
			var window = gameState.OpenWindow(WindowPrefab);
			if (window is DialogueWindow dialogueWindow)
				dialogueWindow.SetData(this, gameState, source);
			else
				gameState.CloseAllWindow();
		}
	}
}
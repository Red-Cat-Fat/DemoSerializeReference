using System;
using UnityEngine;

namespace Gameplay.DialogueSystem
{
	[Serializable]
	public class FinishedNode : INode
	{
		public string TitleNode
			=> FinishedVariant;
		public string FinishedVariant;
		public void Apply(GameState gameState, GameObject source)
		{
			gameState.CloseAllWindow();
		}
	}
}
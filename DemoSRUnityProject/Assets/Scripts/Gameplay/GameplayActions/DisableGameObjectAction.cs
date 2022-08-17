using System;
using UnityEngine;

namespace Gameplay.GameplayActions
{
	[Serializable]
	public class DisableGameObjectAction : IGamePlayAction
	{
		public void Apply(GameState gameState, GameObject source)
			=> source.SetActive(false);
	}
}
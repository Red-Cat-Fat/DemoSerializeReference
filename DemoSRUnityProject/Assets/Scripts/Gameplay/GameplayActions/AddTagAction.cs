using System;
using Gameplay.Tags;
using UnityEngine;

namespace Gameplay.GameplayActions
{
	[Serializable]
	public class AddTagAction : IGamePlayAction
	{
		public GameTag CollisionTag;
		
		public void Apply(GameState gameState, GameObject source)
			=> gameState.CollisionWith(CollisionTag);
	}
}
using UnityEngine;

namespace Gameplay.GameplayActions
{
	public interface IGamePlayAction
	{
		void Apply(GameState gameState, GameObject source);
	}
}
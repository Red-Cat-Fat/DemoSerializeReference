using UnityEngine;

namespace Gameplay.DialogueSystem
{
	public interface INode
	{
		string TitleNode { get; }
		void Apply(GameState gameState, GameObject source);
	}
}
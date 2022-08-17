using TMPro;
using UnityEngine;

namespace Gameplay.DialogueSystem.Components
{
	public class DialogueVariantButton : MonoBehaviour
	{
		public TMP_Text ButtonTitle;

		private INode _node;
		private GameState _gameState;
		private GameObject _source;

		public void SetNode(INode node, GameState gameState, GameObject source)
		{
			_node = node;
			_source = source;
			_gameState = gameState;
			ButtonTitle.text = node.TitleNode;
		}

		public void ClickAction()
		{
			_node.Apply(_gameState, _source);
		}
	}
}
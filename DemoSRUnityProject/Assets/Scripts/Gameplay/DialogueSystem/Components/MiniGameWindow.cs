using TMPro;
using UnityEngine;

namespace Gameplay.DialogueSystem.Components
{
	
	public class MiniGameWindow : WindowBase
	{
		public TMP_InputField InputField;

		private StartMiniGameNode _data;
		private GameState _gameState;
		private GameObject _source;

		public void SetData(StartMiniGameNode data, GameState gameState, GameObject source)
		{
			_source = source;
			_gameState = gameState;
			_data = data;
		}
		
		public void CheckGameAction()
		{
			if (_data.TargetValue == int.Parse(InputField.text))
				_data.WinNode.Apply(_gameState, _source);
			else
				_data.LoseNode.Apply(_gameState, _source);
		}
		
		public override void Reset()
		{
			InputField.text = "";
		}
	}
}
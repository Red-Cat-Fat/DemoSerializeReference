using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Gameplay.DialogueSystem.Components
{
	public class DialogueWindow : WindowBase
	{
		public Transform ButtonContainer;
		public GameObject VariantPrefab;
		public TMP_Text MainContentText;
		
		private List<GameObject> _buttons = new List<GameObject>();
		
		public override WindowType TypeWindow
			=> WindowType.Dialogue;


		public void SetData(DialogueNode dialogueNode, GameState gameState, GameObject source)
		{
			foreach (var nodeContainer in dialogueNode.NextNodes)
			{
				if(!nodeContainer.Condition.Check(gameState))
					continue;
				
				var buttonGO = Instantiate(VariantPrefab, ButtonContainer);
				_buttons.Add(buttonGO);
				var variantButton = buttonGO.GetComponent<DialogueVariantButton>();
				variantButton.SetNode(nodeContainer.Node, gameState, source);
			}
			MainContentText.text = dialogueNode.TextContain;
		}
		
		public override void Reset()
		{
			foreach (var button in _buttons)
			{
				Destroy(button);
			}
		}
	}
}
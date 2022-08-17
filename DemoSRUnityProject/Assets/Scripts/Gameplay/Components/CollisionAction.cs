using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Components
{
	public class CollisionAction : MonoBehaviour
	{
		public List<ActionContainer> ActionList;
		
		private void OnCollisionEnter(Collision collision)
		{
			var player = collision.gameObject.GetComponent<Player>();
			if(player == null)
				return;
			
			foreach (var container in ActionList)
			{
				if (container.Condition.Check(player.GameState))
				{
					container.GamePlayAction.Apply(player.GameState, gameObject);
					return;
				}
			}
		}
	}
}
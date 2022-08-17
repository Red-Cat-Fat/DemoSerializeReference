using UnityEngine;

namespace Gameplay.Tags
{
	[CreateAssetMenu(fileName = "GameTag", menuName = "Demo project/GameTag", order = 0)]
	public class GameTag : ScriptableObject
	{
		public string TagName;
	}
}
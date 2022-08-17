using UnityEngine;

namespace Gameplay.DialogueSystem.Components
{
	public abstract class WindowBase : MonoBehaviour
	{
		public enum WindowType
		{
			None = 0,
			Dialogue = 1,
			MiniGame = 2
		}

		public virtual WindowType TypeWindow { get; }
		public abstract void Reset();
	}
}
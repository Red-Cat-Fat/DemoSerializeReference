using System;
using System.Collections.Generic;
using System.Linq;
using Gameplay.Components;
using Gameplay.DialogueSystem.Components;
using Gameplay.Tags;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Gameplay
{
	public class GameState
	{
		private List<GameTag> _collisionWith = new List<GameTag>();
		private List<WindowBase> _windowPool = new List<WindowBase>();

		public WindowBase OpenWindow(GameObject windowPrefab)
		{
			foreach (var window in _windowPool)
			{
				window.gameObject.SetActive(false);
			}

			var windowComponent = windowPrefab.GetComponent<WindowBase>();
			if (windowComponent == null)
				return null;
			
			var windowIndex = _windowPool.FindIndex(window => window.TypeWindow == windowComponent.TypeWindow);
			if (windowIndex >= 0)
			{
				_windowPool[windowIndex].gameObject.SetActive(true);
				_windowPool[windowIndex].Reset();
				return _windowPool[windowIndex];
			}

			var windowGameObject = Object.Instantiate(windowPrefab);
			var resultComponent = windowGameObject.GetComponent<WindowBase>();
			_windowPool.Add(resultComponent);
			resultComponent.Reset();
			return resultComponent;
		}
		
		public void CloseAllWindow()
		{
			foreach (var windowBase in _windowPool)
			{
				windowBase.gameObject.SetActive(false);
			}
		}

		public void CollisionWith(GameTag collisionWith)
			=> _collisionWith.Add(collisionWith);

		public bool IsHasTag(GameTag isCollisionWith)
			=> _collisionWith.Contains(isCollisionWith);
	}
}
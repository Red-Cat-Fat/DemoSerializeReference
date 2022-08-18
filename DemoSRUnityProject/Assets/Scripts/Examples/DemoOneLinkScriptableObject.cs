using System.Collections.Generic;
using Gameplay.DialogueSystem;
using UnityEngine;

namespace Examples
{
	[CreateAssetMenu(fileName = "OneLink", menuName = "Demo project/OneLink", order = 0)]
	public class DemoOneLinkScriptableObject : ScriptableObject
	{
		public List<DemonstrationClass> NotLinkedClasses;
		[SerializeReference]
		[SR(typeof(IDemonstrationClass))]
		public List<DemonstrationClass> LinkedClasses = new List<DemonstrationClass>();

		public ConditionNodeContainer DemoNodes;
	}
}
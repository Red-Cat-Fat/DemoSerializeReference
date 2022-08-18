using UnityEngine;

namespace Examples
{
	[CreateAssetMenu(fileName = "CanBeNull", menuName = "Demo project/DemoSOCanBeNull", order = 0)]
	public class DemoCanBeNullScriptableObject : ScriptableObject
	{
		public DemonstrationClass CantBeNull = null;
		[SerializeReference]
		public DemonstrationClass IsNull = null;
		
		[SR(typeof(IDemonstrationClass))]
		[SerializeReference]
		public IDemonstrationClass IsNotNull 
			= new DemonstrationClass { DataInteger = 42 };
	}
}
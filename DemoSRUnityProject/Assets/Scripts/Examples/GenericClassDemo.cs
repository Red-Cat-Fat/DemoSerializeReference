using UnityEngine;

namespace Examples
{
	[CreateAssetMenu(fileName = "DemoGenericClass", menuName = "Demo project/DemoGenericClass", order = 0)]
	public class GenericClassDemo : ScriptableObject
	{
		[SerializeReference]
		public GenericDemonstrationClass<int> NonSerializedIntGen = new IntGen { Value = 101 };
		[SerializeReference]
		public IntGen SerializedIntGen = new IntGen { Value = 42 };

		public void Dem()
		{
			var res = NonSerializedIntGen != SerializedIntGen;
		}
	}
}
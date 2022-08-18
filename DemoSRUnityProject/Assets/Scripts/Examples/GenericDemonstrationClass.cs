using System;

namespace Examples
{
	[Serializable]
	public class GenericDemonstrationClass<T>
	{
		public T Value;
	}
	
	[Serializable]
	public class IntGen : GenericDemonstrationClass<int>
	{
	}
}
using System;

namespace Examples
{
	public interface IDemonstrationClass
	{
		
	}
	
	[Serializable]
	public class DemonstrationClass : IDemonstrationClass
	{
		public string TitleName;
		public int DataInteger;
	}
	
	
}
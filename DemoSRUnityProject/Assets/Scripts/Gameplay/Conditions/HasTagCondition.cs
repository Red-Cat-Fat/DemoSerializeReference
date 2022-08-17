using System;
using Gameplay.Tags;

namespace Gameplay.Conditions
{
	[Serializable]
	public class HasTagCondition : ICondition
	{
		public GameTag IsCollisionWith;
		public bool Invert;
		
		public bool Check(GameState state)
			=> Invert
				   ? !state.IsHasTag(IsCollisionWith)
				   : state.IsHasTag(IsCollisionWith);
	}
}
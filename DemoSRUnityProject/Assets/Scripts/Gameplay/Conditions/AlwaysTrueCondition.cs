namespace Gameplay.Conditions
{
	public class AlwaysTrueCondition : ICondition
	{
		public bool Check(GameState state)
			=> true;
	}
}
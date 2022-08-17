namespace Gameplay.Conditions
{
	public interface ICondition
	{
		bool Check(GameState state);
	}
}
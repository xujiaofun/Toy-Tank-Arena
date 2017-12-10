using Entitas;

public sealed class ToyTankArenaSystems : Feature
{
	public ToyTankArenaSystems(Contexts contexts) : base("ToyTankArenaSystems")
	{
		Add (new InputSystems (contexts));

		Add (new LevelSystems (contexts));

		Add (new FireSystems (contexts));

		Add (new MovemontSystems (contexts));

		Add (new RenderSystems (contexts));
	}
}
using Entitas;

public sealed class MovemontSystems : Feature
{
	public MovemontSystems (Contexts contexts) : base("MovemontSystems")
	{
		Add (new ProcessMovementSystem (contexts));
		Add (new VelocitySystem (contexts));
	}
}

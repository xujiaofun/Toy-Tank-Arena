using Entitas;

public sealed class FireSystems : Feature
{
	public FireSystems (Contexts contexts) : base("FireSystems")
	{
		Add (new FireSystem (contexts));
	}
}

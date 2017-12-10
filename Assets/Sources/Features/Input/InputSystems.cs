using Entitas;

public sealed class InputSystems : Feature
{
	public InputSystems (Contexts contexts) : base("InputSystems")
	{
		Add (new MovementInputSystem (contexts));
		Add (new MouseInputSystem (contexts));
		Add (new FireInputSystem (contexts));
	}
}
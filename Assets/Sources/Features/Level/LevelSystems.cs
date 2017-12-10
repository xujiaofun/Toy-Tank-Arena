using Entitas;

public sealed class LevelSystems : Feature
{
	public LevelSystems (Contexts contexts) : base("LevelSystems")
	{
		Add (new CreateLevelSystem (contexts));
	}
}

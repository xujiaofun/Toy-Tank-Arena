using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique]
public sealed class LevelComponent : IComponent
{
	public int value;
}

using Entitas;
using System.Collections.Generic;

public sealed class UpdatePositionSystem : ReactiveSystem<GameEntity>
{
	public UpdatePositionSystem (Contexts contexts) : base (contexts.game)
	{
		
	}

	protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
	{
		return context.CreateCollector (
			GameMatcher.AllOf(GameMatcher.Positon, GameMatcher.GameObject)
		);
	}

	protected override bool Filter (GameEntity entity)
	{
		return true;
	}

	protected override void Execute (List<GameEntity> entities)
	{
		foreach (var e in entities) {
			e.gameObject.transform.position = e.positon.value;
		}
	}
}

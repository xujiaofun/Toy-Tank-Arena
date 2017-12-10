using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class CreateLevelSystem : ReactiveSystem<GameEntity>, IInitializeSystem
{
	readonly GameContext _game;

	public CreateLevelSystem (Contexts contexts) : base (contexts.game)
	{
		_game = contexts.game;
	}

	public void Initialize ()
	{
		var player = _game.CreateEntity();
		player.isControllable = true;
		player.isTank = true;
		player.AddResource ("Prefabs/Tank");
		player.AddSpeed (1f);
		player.AddFireTime (0);
		player.AddPositon (new Vector3 (0, 0, 0));
	}

	protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
	{
		return context.CreateCollector (GameMatcher.Level);
	}

	protected override bool Filter (GameEntity entity)
	{
		return true;
	}

	protected override void Execute (List<GameEntity> entities)
	{
		foreach (var e in entities) {
			
		}
	}
}
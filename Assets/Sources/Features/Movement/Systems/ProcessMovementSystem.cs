using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class ProcessMovementSystem : ReactiveSystem<InputEntity>
{
	readonly GameContext _game;

	public ProcessMovementSystem (Contexts contexts) : base (contexts.input)
	{
		_game = contexts.game;
	}

	protected override ICollector<InputEntity> GetTrigger (IContext<InputEntity> context)
	{
		return context.CreateCollector (InputMatcher.Movement);
	}

	protected override bool Filter (InputEntity entity)
	{
		return true;
	}

	protected override void Execute (List<InputEntity> entities)
	{
		var e = entities.SingleEntity ();

		var player = _game.controllableEntity;
		if (player.hasTankView) {
			var movement = e.movement.value;
			var moveDelta = movement.normalized * player.speed.value * Time.deltaTime;

			player.ReplacePositon (player.positon.value + moveDelta);
		}
	}
}

using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class RotationBarrelSystem : ReactiveSystem<InputEntity>
{
	readonly GameContext _game;

	public RotationBarrelSystem (Contexts contexts) : base (contexts.input)
	{
		_game = contexts.game;
	}

	protected override ICollector<InputEntity> GetTrigger (IContext<InputEntity> context)
	{
		return context.CreateCollector (InputMatcher.MousePosition);
	}

	protected override bool Filter (InputEntity entity)
	{
		return true;
	}

	protected override void Execute (List<InputEntity> entities)
	{
		var e = entities.SingleEntity ();
		var player = _game.controllableEntity;

		var barrel = player.tankView.value.barrel;
		var forward = e.mousePosition.value - barrel.transform.position;
		player.ReplaceBarrelDirection (forward);

		barrel.rotation = Quaternion.identity;
		barrel.LookAt2D (e.mousePosition.value);
//		barrel.Rotate(Vector3.forward, (Mathf.Atan2(forward.y, forward.x) * 180f / Mathf.PI) - 90f);
//		barrel.right = forward;
	}
}
using Entitas;
using System.Collections.Generic;

public sealed class FireSystem : ReactiveSystem<InputEntity>
{
	readonly GameContext _game;

	public FireSystem (Contexts contexts) : base (contexts.input)
	{
		_game = contexts.game;
	}

	protected override ICollector<InputEntity> GetTrigger (IContext<InputEntity> context)
	{
		return context.CreateCollector (InputMatcher.FireInput);
	}

	protected override bool Filter (InputEntity entity)
	{
		return true;
	}

	protected override void Execute (List<InputEntity> entities)
	{
		var e = entities.SingleEntity ();
		var input = e.fireInput;
		var player = _game.controllableEntity;

		var bullet = _game.CreateEntity ();
		bullet.isBullet = true;
		bullet.AddPositon (input.origin);
		bullet.AddBulletStart (input.origin, input.direction);
		bullet.AddVelocity (input.direction.normalized * 4f); 
		bullet.AddResource("Prefabs/Bullet/Blue");
	}
}

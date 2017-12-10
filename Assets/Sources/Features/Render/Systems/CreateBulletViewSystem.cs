using Entitas;
using Entitas.Unity;
using System.Collections.Generic;
using UnityEngine;

public sealed class CreateBulletViewSystem : ReactiveSystem<GameEntity>
{
	readonly GameContext _game;

	public CreateBulletViewSystem (Contexts contexts) : base (contexts.game)
	{
		_game = contexts.game;
	}

	protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
	{
		return context.CreateCollector (GameMatcher.AllOf(GameMatcher.Bullet, GameMatcher.Resource));
	}

	protected override bool Filter (GameEntity entity)
	{
		return true;
	}

	protected override void Execute (List<GameEntity> entities)
	{
		foreach (var e in entities) {
			var prefab = Resources.Load<GameObject> ("Prefabs/Bullet");

			var go = GameObject.Instantiate (prefab);
			go.transform.LookAt2D (e.bulletStart.direction);

			var view = go.AddComponent<BulletView> ();

			//var angle = (Mathf.Atan2(e.bulletStart.direction.y, e.bulletStart.direction.x) * 180 / Mathf.PI) - 270f;
			//view.rigidbody.MoveRotation (angle);

			go.Link (e, _game);

			e.AddGameObject (go, go.transform);
			e.AddBulletView (view);
		}
	}
}

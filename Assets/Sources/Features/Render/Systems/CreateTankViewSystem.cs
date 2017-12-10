using Entitas;
using Entitas.Unity;
using System.Collections.Generic;
using UnityEngine;

public sealed class CreateTankViewSystem : ReactiveSystem<GameEntity>, IInitializeSystem
{
	readonly GameContext _game;
	readonly IGroup<GameEntity> _viewGroup;

	public CreateTankViewSystem (Contexts contexts) : base (contexts.game)
	{
		_game = contexts.game;
		_viewGroup = _game.GetGroup (GameMatcher.AllOf(GameMatcher.Resource, GameMatcher.Tank)
			                                    .NoneOf(GameMatcher.TankView));
	}

	public void Initialize ()
	{
		foreach (var e in _viewGroup.GetEntities()) {
			AddView (e);
		}
	}

	protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
	{
		return context.CreateCollector (GameMatcher.AllOf(GameMatcher.Resource, GameMatcher.Tank)
												   .NoneOf(GameMatcher.TankView));
	}

	protected override bool Filter (GameEntity entity)
	{
		return !entity.hasTankView;
	}

	protected override void Execute (List<GameEntity> entities)
	{
		foreach (var e in entities) {
			AddView (e);
		}
	}

	void AddView(GameEntity e) {
		var prefab = Resources.Load<GameObject> (e.resource.value);

		var go = GameObject.Instantiate (prefab);

		go.Link (e, _game);
		e.AddTankView (go.GetComponent<TankView> ());
		e.AddGameObject (go, go.transform);
	}
}

using Entitas;
using UnityEngine;

public sealed class VelocitySystem : IExecuteSystem
{
	readonly IGroup<GameEntity> _movableGroups;
	public VelocitySystem (Contexts contexts)
	{
		_movableGroups = contexts.game.GetGroup (
			GameMatcher.AllOf (GameMatcher.Positon, GameMatcher.Velocity, GameMatcher.BulletView)
		);
	}

	public void Execute ()
	{
		foreach (var e in _movableGroups.GetEntities()) {
			var bulletView = e.bulletView.value;
			//bulletView.rigidbody.MovePosition (e.positon.value + e.velocity.value * Time.deltaTime);
			e.ReplacePositon (e.positon.value + e.velocity.value * Time.deltaTime);
		}
	}
}

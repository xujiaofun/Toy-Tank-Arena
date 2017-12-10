using Entitas;
using UnityEngine;

public sealed class FireInputSystem : IExecuteSystem, ICleanupSystem
{
	readonly InputContext _input;
	readonly GameContext _game;
	readonly IGroup<InputEntity> _inputGroup;

	public FireInputSystem (Contexts contexts)
	{
		_game = contexts.game;
		_input = contexts.input;
		_inputGroup = _input.GetGroup (InputMatcher.FireInput);
	}

	public void Execute ()
	{
		var player = _game.controllableEntity;
		var passTime = Time.realtimeSinceStartup - player.fireTime.value;
		if (Input.GetButton ("Fire1") && passTime >= 0.3f) {
			player.ReplaceFireTime (Time.realtimeSinceStartup);

			var barrel = player.GetFirePos ();
			var direction = player.barrelDirection.value;
			_input.CreateEntity ().AddFireInput (barrel.position, direction);
		}
	}

	public void Cleanup ()
	{
		foreach (var e in _inputGroup.GetEntities()) {
			e.Destroy ();
		}
	}
}

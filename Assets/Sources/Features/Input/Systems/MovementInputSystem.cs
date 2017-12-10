using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class MovementInputSystem : IExecuteSystem, ICleanupSystem
{
	readonly InputContext _input;
	readonly IGroup<InputEntity> _movementGroup;

	public MovementInputSystem (Contexts contexts)
	{
		_input = contexts.input;
		_movementGroup = _input.GetGroup (InputMatcher.Movement);
	}

	public void Execute ()
	{
		var h = Input.GetAxisRaw ("Horizontal");
		var v = Input.GetAxisRaw ("Vertical");

		if (h != 0 || v != 0) {
			//Debug.LogFormat ("h = {0} v = {1}, {2}, {3}", h, v, Input.GetKey(KeyCode.A), Input.GetKey(KeyCode.W));
			var e = _input.CreateEntity ();
			e.AddMovement (new Vector3 (h, v, 0f));
		}



	}

	public void Cleanup ()
	{
		foreach (var e in _movementGroup.GetEntities()) {
			e.Destroy ();
		}
	}
}
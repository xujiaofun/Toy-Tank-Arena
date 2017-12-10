using Entitas;
using UnityEngine;

public sealed class MouseInputSystem : IExecuteSystem, ICleanupSystem
{
	readonly InputContext _input;
	readonly IGroup<InputEntity> _mousePositions;
	public MouseInputSystem (Contexts contexts)
	{
		_input = contexts.input;
		_mousePositions = _input.GetGroup (InputMatcher.MousePosition);
	}

	public void Execute ()
	{
		var position = Input.mousePosition;
		var pos = Camera.main.ScreenToWorldPoint (position);
		pos.z = 0;
		var e = _input.CreateEntity ();
		e.AddMousePosition (pos);
	}

	public void Cleanup ()
	{
		foreach (var e in _mousePositions.GetEntities()) {
			e.Destroy ();
		}
	}
}

using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class AdjustTankBodyAngleSystem : ReactiveSystem<GameEntity>
{
	public AdjustTankBodyAngleSystem (Contexts contexts) : base (contexts.game)
	{
		
	}

	protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
	{
		return context.CreateCollector (GameMatcher.AllOf(GameMatcher.Positon, GameMatcher.TankView, GameMatcher.GameObject));
	}

	protected override bool Filter (GameEntity entity)
	{
		return true;
	}

	protected override void Execute (List<GameEntity> entities)
	{
		foreach (var e in entities) {
			var move = e.positon.value - e.gameObject.transform.position;
			var body = e.tankView.value.body;
			//body.rotation = Quaternion.identity;
			var angle = (Mathf.Atan2 (move.y, move.x) * 180f / Mathf.PI + 360f) % 360f;

			if (angle >= 180f) {
				angle = (angle - 180f);
			}

			angle = angle - 90f;

			var angleStart = (body.eulerAngles.z);
			if (angleStart >= 270f) {
				angleStart = angleStart - 360f;
			}
			if (angleStart != angle) {
				var d = (angle - angleStart);
				if (Mathf.Abs (d) <= 5) {
					angleStart = angle;
				} else {
					angleStart += Mathf.Sign(d) * 5f;
				}

			}
			//Debug.LogFormat ("ddd {0} {1}", body.eulerAngles, angle);
			body.rotation = Quaternion.Euler (new Vector3(0,0,angleStart));
			//body.Rotate (Vector3.forward, angle);//Mathf.LerpAngle(angle0, angle, Time.deltaTime));
		}
	}
}

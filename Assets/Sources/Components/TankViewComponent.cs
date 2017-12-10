using Entitas;
using UnityEngine;

[Game]
public sealed class TankViewComponent : IComponent
{
	public TankView value;
}

public static class TankViewComponentExtensions
{
	public static Transform GetBarrel(this GameEntity e)
	{
		return e.tankView.value.barrel;
	}

	public static Transform GetFirePos(this GameEntity e)
	{
		return e.tankView.value.firePos;
	}
}

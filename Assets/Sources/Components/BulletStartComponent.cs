using Entitas;
using UnityEngine;

[Game]
public sealed class BulletStartComponent : IComponent
{
	public Vector3 value;
	public Vector3 direction;
}

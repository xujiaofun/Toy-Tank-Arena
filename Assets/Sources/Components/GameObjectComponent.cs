using Entitas;
using UnityEngine;

[Game]
public sealed class GameObjectComponent : IComponent
{
	public GameObject value;
	public Transform transform;
}

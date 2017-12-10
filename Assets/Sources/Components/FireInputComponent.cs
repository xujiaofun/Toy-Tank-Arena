using Entitas;
using UnityEngine;

[Input]
public sealed class FireInputComponent : IComponent
{
	public Vector3 origin;
	public Vector3 direction;
}

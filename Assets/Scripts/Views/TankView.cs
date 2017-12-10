using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour {

	public Transform barrel;

	public BoxCollider2D collider2d;

	public Rigidbody2D rigidbody2d;

	public Transform mTransform;

	public Transform firePos;

	public Transform body;

	void Awake() {
		mTransform = gameObject.transform;
		collider2d = gameObject.GetComponent<BoxCollider2D> ();
		rigidbody2d = gameObject.GetComponent<Rigidbody2D> ();
	}
}

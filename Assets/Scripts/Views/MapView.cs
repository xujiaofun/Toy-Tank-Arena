using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapView : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		Debug.LogFormat ("OnTriggerEnter2D");
	}

	void OnTriggerExit2D(Collider2D other) {
		Debug.LogFormat ("OnTriggerExit2D");
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.LogFormat ("OnCollisionEnter2D");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	ToyTankArenaSystems _system;
	// Use this for initialization
	void Start () {
		var contexts = Contexts.sharedInstance;
		_system = new ToyTankArenaSystems (contexts);

		_system.Initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		_system.Execute ();
		_system.Cleanup ();
	}

	void Destroy()
	{
		_system.TearDown ();
	}
}

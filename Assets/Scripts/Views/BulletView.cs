using UnityEngine;
using System.Collections;

public class BulletView : MonoBehaviour
{
	public Rigidbody2D rigidbody;
	// Use this for initialization
	void Awake ()
	{
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}


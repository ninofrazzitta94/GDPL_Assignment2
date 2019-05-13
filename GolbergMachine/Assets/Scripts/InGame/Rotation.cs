 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public int Speed = 100;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		rb.AddTorque (new Vector3 (Time.deltaTime * Speed, 0,0 ));
		
	}
}

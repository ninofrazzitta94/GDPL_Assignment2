using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxe : MonoBehaviour {

	private Rigidbody rb;
	public int force;

	public GameObject Ball1;
	public GravitySwapperAndTriggers script;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		if (Ball1 !=null) {
			script = Ball1.GetComponent<GravitySwapperAndTriggers> ();
			//Push
			if (script.OnPush == true) {

				rb.AddForce (0, 0, -force);
				script.OnPush = false;
			}
			//Stop push
			if (transform.position.z < 25.4f) {
				rb.velocity = Vector3.zero;
			}
			if (transform.position.z > 25.7f) {
				rb.velocity = Vector3.zero;
			}		
		}
	}
}

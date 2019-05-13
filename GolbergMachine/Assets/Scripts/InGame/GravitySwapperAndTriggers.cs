using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwapperAndTriggers : MonoBehaviour {

	private Rigidbody rb;

	public bool gravitySwitch = false;
	public int oppsiteGravity = 1;

	public bool OnPush = false;

	public AudioSource audiobounce;

	void Start () {

		rb = GetComponent<Rigidbody>();
		audiobounce = GetComponent<AudioSource>();
		
	}

	void FixedUpdate () {

		if (gravitySwitch == true) {

			Vector3 opGrav = new Vector3 (0, oppsiteGravity, 0);
			rb.AddForce (opGrav);
			}
	}
	void OnCollisionEnter (Collision col) {

		if (col.gameObject.name == "UpTrigger") {
		gravitySwitch = true;
		}

		if (col.gameObject.name == "DownTrigger") {
			gravitySwitch = false;
		}

		if (col.gameObject.name == "PushTrigger") {
			OnPush = true;
			}

		if (col.gameObject.tag == "Roll") {
			audiobounce.pitch = (Random.Range (0.6f, 0.9f));
			audiobounce.Play ();
		}
	}
}




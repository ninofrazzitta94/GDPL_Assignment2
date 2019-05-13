using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

	private Rigidbody rb;

	public float vent;
	public bool fly = false;

	public float speed;

	public AudioSource audiobounce;

	void Start () {
		
		rb = GetComponent<Rigidbody>();
		audiobounce = GetComponent<AudioSource>();
	}

	void FixedUpdate () {
		
		//waiting for trigger for vent
		if (fly == true) {
			vent = Random.Range (-0.5f, 3.5f);
			Vector3 atas = new Vector3 (0, vent, 0);
			rb.AddForce (atas * speed);
			rb.drag = 2.5f;
		} else {
			rb.drag = 0;
		}
	}
	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "Bounce") {
			audiobounce.pitch = (Random.Range (0.6f, 0.9f));
			audiobounce.Play ();
		}
	}
}

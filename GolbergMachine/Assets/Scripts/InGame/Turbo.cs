using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour {

	public GameObject Ball2;
	public Rigidbody Rb;

	public AudioSource whoosh;

	void Start () {
		
		whoosh = GetComponent<AudioSource>();
	}

	void Update () {

		Rb = Ball2.GetComponent<Rigidbody> ();

	}

	void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Ball") {
			whoosh.Play ();
			Rb.AddForce (0, 0, 50);
		}
	}
}

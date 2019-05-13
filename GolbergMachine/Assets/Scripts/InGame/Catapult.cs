using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour {
	
	public bool fire;
	private Rigidbody rb;
	public int speed = 50;

	public GameObject Button1;
	public ButtonTrigger2 script;

	public AudioSource sling;

	void Start () {

		rb = GetComponent<Rigidbody> ();
		script = Button1.GetComponent<ButtonTrigger2> ();
		sling = GetComponent<AudioSource>();

	}

	void FixedUpdate () {

		if (script.buttonOn == true) {
			fire = true;
			sling.Play ();
			script.buttonOn = false;

		}

		if (fire == true) {
			
			rb.AddTorque (0, 0, speed);
		}
	}
}

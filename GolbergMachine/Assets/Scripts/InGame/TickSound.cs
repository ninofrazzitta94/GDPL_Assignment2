using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickSound : MonoBehaviour {
	
	public AudioSource Bclick;

	void Start () {
		Bclick = GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "Bounce") {
			Bclick.Play();
		}
	}
}
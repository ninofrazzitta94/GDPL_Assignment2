using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exlplosion : MonoBehaviour {

	public GameObject Platform;
	public Floating script;

	public bool boom = false;

	public AudioSource explosion;

	void Start () {
		
		script = Platform.GetComponent<Floating> ();
		explosion = GetComponent<AudioSource>();
	}

	void FixedUpdate () {
		
		script = Platform.GetComponent<Floating> ();
		
		if (script.counter == 20) {
			Explode ();
			script.counter = 21;
		}
	}

	void Explode() {
		
		var exp = GetComponent<ParticleSystem>();
		explosion.Play ();
		exp.Play();
		Destroy(gameObject, exp.main.duration);
	}
}

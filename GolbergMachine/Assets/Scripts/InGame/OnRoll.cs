using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRoll : MonoBehaviour {


	private Rigidbody rb;
	public bool _grounded = false;


	[SerializeField]public AudioClip walkSound;

	//sources management
	public AudioSource[] sounds;
	public AudioSource noise1;
	public AudioSource noise2;
	private bool isPlaying = false;
	public float _speed = 0.5f;

	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		sounds = GetComponents<AudioSource>();
		noise1 = sounds[0];
		noise2 = sounds[1];
		noise2.clip = walkSound; 


	}
	void Update () {
		
		//adjusting pitch dynamicaly depending of the force given
		noise2.pitch = rb.velocity.magnitude / _speed + 1f;

		//playing the rolling sound only over a specific force
		if (rb.velocity.magnitude >= 0.1 && _grounded ==true) {
			
			if (!isPlaying == true) {
				noise2.Play ();
				noise2.volume = 1;
				noise2.loop = true;
				isPlaying = true;
			}
		} else {
			noise2.Stop ();
			isPlaying = false;
		}
	}
}


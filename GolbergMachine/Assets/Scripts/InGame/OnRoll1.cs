using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRoll1 : MonoBehaviour {


	private Rigidbody rb;
	public bool _grounded1 = false;
	//different clips for the same object
	[SerializeField]public AudioClip bongSound;
	[SerializeField]public AudioClip rollSound;
	[SerializeField]public AudioClip hitSound;
	[SerializeField]public AudioClip magnSound;
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
		noise2.clip = rollSound; 


	}
	void Update () {
		
		//adjusting pitch dynamicaly depending of the force given
		noise2.pitch = rb.velocity.magnitude / _speed + 1f;
		//playing the rolling sound only over a specific force
		if (rb.velocity.magnitude >= 0.1 && _grounded1 ==true) {
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
	void OnCollisionStay (Collision col){
		
		//allowing the rolling sound on platform touch
		if (col.gameObject.tag == "Roll") {
			_grounded1 = true;
		} else {
			_grounded1 = false;
		}
	}
		void OnCollisionEnter (Collision col){
		if (col.gameObject.name == "Funnel") {
			noise1.PlayOneShot (bongSound , 1f);
		}
			if (col.gameObject.name == "Push") {
				noise1.PlayOneShot (hitSound , 1f);
			}
		if (col.gameObject.name == "UpTrigger") {
			noise1.PlayOneShot (magnSound , 0.7f);
		}
		if (col.gameObject.name == "DownTrigger") {
			noise1.PlayOneShot (magnSound , 0.7f);
		}
	}
	
}



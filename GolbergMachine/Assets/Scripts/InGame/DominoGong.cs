using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoGong : MonoBehaviour {

	public AudioSource gong;
	float _pitch = 1f;

	void Start () {
		gong = GetComponent<AudioSource>();
	}

	void OnCollisionStay (Collision col){
		
		//increase the pitch
		_pitch += Time.deltaTime/3;
	}

	void OnCollisionEnter (Collision col) {
		
		if (col.gameObject.tag == "Gong") {
			gong.pitch = _pitch;
			gong.Play ();
		}
	}
}

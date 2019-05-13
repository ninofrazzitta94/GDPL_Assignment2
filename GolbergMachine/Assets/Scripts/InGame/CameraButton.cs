using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraButton : MonoBehaviour {

	public bool buttonOnCam = false;
	public bool revbuttonCam = false;

	public Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}
		
	void OnTriggerEnter(Collider col) {
		
		//trigger the bucket focusing animation
		if (col.gameObject.name == "Player") {
			buttonOnCam = true;

		}
	}

	void OnTriggerExit (Collider col) {

		if (col.gameObject.name == "Player") {
			revbuttonCam = true;
		}
	}
}
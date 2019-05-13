using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour {

	public bool _grounded = false;
	public bool _pushed = false;

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.name =="grav1"){

			_grounded = true;
	}
		if (col.gameObject.name == "Push") {

			_pushed = true;
		}
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger2 : MonoBehaviour {

	public bool buttonOn = false;

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.name == "Domino5") {
			buttonOn = true;

		}
	}
}
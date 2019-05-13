using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger1 : MonoBehaviour {

	public bool buttonOn = false;

	void FixedUpdate () {

		if (transform.position.y < 2.56f) {
			buttonOn = true;
		
	}
  }
}


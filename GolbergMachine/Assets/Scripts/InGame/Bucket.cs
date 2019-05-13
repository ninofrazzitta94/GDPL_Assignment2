using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour {

	public GameObject ButtonTrigger1;

	public ButtonTrigger1 script;
	private Rigidbody rb;

	void FixedUpdate () {
		
		script = ButtonTrigger1.GetComponent<ButtonTrigger1> ();
		rb = GetComponent<Rigidbody> ();

		if (transform.rotation.eulerAngles.z > 90) {
			
			rb.isKinematic = true;
		}

		if (script.buttonOn == true) {
			//on button down apply force
			rb.isKinematic = false;
			if (transform.rotation.eulerAngles.z < 90) {
			rb.AddTorque (new Vector3 (0, 0, 900000000));
			script.buttonOn = false;
			}
		}else{
			
			rb.isKinematic = true;
			rb.angularVelocity = Vector3.zero;
			rb.velocity = Vector3.zero;
			script.buttonOn = false;

	}
}
}

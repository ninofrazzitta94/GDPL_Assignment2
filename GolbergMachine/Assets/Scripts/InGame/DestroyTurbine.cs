using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurbine : MonoBehaviour {

	public GameObject LastPlatform;
	public Floating script;

	void Update () {
		//on explosion destroy turbines under
		script = LastPlatform.GetComponent<Floating> ();

		if (script.counter == 20) {
			Destroy (gameObject);
		}
	}
}

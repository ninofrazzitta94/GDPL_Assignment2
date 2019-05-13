using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPendulum : MonoBehaviour {


	public GameObject Pendulum1;
	public Pendulum1 script;
	public AudioSource click;

	void Start () {
		click = GetComponent<AudioSource>();
		script = Pendulum1.GetComponent<Pendulum1>();
	}

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.name == "Rot1") {
			click.Play();
			script.go = true;
		}
	}
}


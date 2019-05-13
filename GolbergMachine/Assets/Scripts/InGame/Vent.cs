using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour {

	public GameObject fly;

	public Fly script;

	void Update() {
		
		//getting script from PlayerController
		script = fly.GetComponent<Fly> ();
			
	}
	void OnTriggerStay () 
	{
		script.fly = true;
	}
	void OnTriggerExit () 
	{
		script.fly = false;
	}

}

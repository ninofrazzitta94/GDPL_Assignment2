using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	public Transform teleportTarget;
	public GameObject thePlayer;

	public AudioSource teleportation;

	void Start () {
		
		teleportation = GetComponent<AudioSource>();
	}

	void OnTriggerEnter (Collider other)
	{
		//setting the position at the new refereced object
		teleportation.Play ();
		thePlayer.transform.position = teleportTarget.transform.position;
	}
}

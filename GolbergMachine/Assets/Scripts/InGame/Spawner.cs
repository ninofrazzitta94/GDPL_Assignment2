using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	
	[SerializeField]
	public Transform boxPrefab; 
	[SerializeField]
	public Transform spawnPoint; 
	public AudioSource tick;

	void Start () {

		tick = GetComponent<AudioSource>();
	}


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Spinner"){
			Transform t = Instantiate (boxPrefab);
			t.position = spawnPoint.position;
			tick.Play();
		}
	

	}
}

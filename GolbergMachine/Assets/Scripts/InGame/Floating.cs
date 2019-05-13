using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {
	
	public int counter = 0;
	public bool expl = false;

	private Rigidbody rb;
	public float radius = 5.0f;
	public float power = 10.0f;

	public GameObject Platform;
	public Floater script;

	public AudioSource hall;
	[SerializeField]public AudioClip _halle;
	bool soundplayed = false;

	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		script = GetComponent<Floater> ();
		hall = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "Ball") {

			counter++;
	}
 }
	void Update () {

		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
		foreach (Collider hit in colliders)
			
			if (counter >=20) {
				
				//Disabling Floater Script as it glitches with rigidbody
				script.enabled = false;
			rb.isKinematic = false;
				expl = true;
		}
		if (expl == true) {
			
			rb.AddExplosionForce (power, explosionPos, radius, 3.0f);
			expl = false;
			//play final song
			if (!soundplayed) {
				
				hall.PlayOneShot (_halle, 0.5f);
				soundplayed = true;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	public bool onGround = false;
	public float jumpSpeed;
	private const int Max_jump = 1;
	private int currentJump = 0;

	public bool gravitySwitch = false;
	public int oppsiteGravity = 1;

	public AudioSource audiobounce;
	[SerializeField]public AudioClip ding;

	public GameObject _player;
	public OnRoll script;
	void Start ()
	{
		script = GetComponent<OnRoll> ();
		rb = GetComponent<Rigidbody> ();
		audiobounce = GetComponent<AudioSource>();
	}

	void FixedUpdate ()
	{
		//Movements
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);

		//Jump with normal gravity
		if (gravitySwitch == false){
			
			if (Input.GetKeyDown ("space") && (onGround || Max_jump > currentJump)) {
				onGround = false;
				currentJump++;
				Vector3 atas = new Vector3 (0, jumpSpeed, 0);
				rb.AddForce (atas * speed);
			}
		}
	    //Gravity Switch
		if (gravitySwitch == true){

			Vector3 opGrav = new Vector3 (0, oppsiteGravity, 0);
			rb.AddForce (opGrav);

	    //Jump with opposite gravity
	     if (Input.GetKeyDown ("space") && (onGround || Max_jump > currentJump)) {
				onGround = false;
				currentJump++;
				Vector3 atas = new Vector3 (0, -jumpSpeed, 0);
				rb.AddForce (atas * speed);
				}
		}
		if (onGround == true) {
			
			script._grounded = true;

		} else {
			
			script._grounded = false;
		}

	}
	void OnCollisionEnter (Collision collision)
	{
		//Allows to jump again
		onGround = true;
		currentJump = 0;
		audiobounce.pitch = (Random.Range (0.6f, 0.9f));
		audiobounce.PlayOneShot (ding, 1f);
	}
}

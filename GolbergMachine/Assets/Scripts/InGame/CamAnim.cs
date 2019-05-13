using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnim : MonoBehaviour {
	//var from animator 
	public Animator anim;
	public CameraController script;

	//var from camera button trigger
	public CameraButton scriptcam;
	public GameObject CameraTrigger;

	// var from Ball1
	public CameraFocus scriptFocus;
	public GameObject Ball1;
	public GameObject _player;
	private Rigidbody rb;

	void Start () {
		anim = GetComponent<Animator>();
		script = GetComponent<CameraController> ();
		scriptcam = CameraTrigger.GetComponent<CameraButton> ();
		scriptFocus = Ball1.GetComponent<CameraFocus>();
		rb = _player.GetComponent<Rigidbody> ();
	}

	void Update () {
		
		//player entering the button area
		if (scriptcam.buttonOnCam == true) {
			anim.SetFloat ("Speed", 1.0f);
			anim.Play ("AfterTrigger");
			script.enabled = false;
			scriptcam.buttonOnCam = false;
		}
		//revesing the first camera animation
		if (scriptcam.revbuttonCam == true) {
			anim.SetFloat ("Speed",-1.0f);
			anim.Play ("AfterTrigger");
			scriptcam.revbuttonCam = false;
		}
		//Ball1 Hitting the platform
		if (scriptFocus._grounded == true) {
			script.enabled = true;
			rb.isKinematic = true;
		}
		// hitting the pusher device
		if (scriptFocus._pushed == true) {
			scriptFocus._grounded = false;
			script.enabled = false;
			anim.Play ("AfterPush");
			scriptFocus._pushed = false;
		}
	}
}

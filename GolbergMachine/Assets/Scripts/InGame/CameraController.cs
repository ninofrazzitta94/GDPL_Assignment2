 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	//Objects to Follow
	public GameObject Player;
	public GameObject Ball1;
	public GameObject pauseMenu;
	public PauseMenu scriptmenu;

	//Camera objective at the moment 
	private GameObject CameraRef;
	private Vector3 offset;

	//Swapping at trigger
	public CameraFocus scriptFocus;
	// Use this for initialization

	void Start () {
		scriptmenu = pauseMenu.GetComponent<PauseMenu>();
		scriptFocus = Ball1.GetComponent<CameraFocus>();
		CameraRef = Player;
		offset = transform.position - CameraRef.transform.position;
	}

	void LateUpdate () {
		
		//when ball touches the platform it will change the camera object to follow
		if (scriptFocus._grounded ==true) {
			CameraRef = Ball1;
		}
		transform.position = CameraRef.transform.position + offset;


	}
	public void GoPause () {
		//calling the pause method in pauseMenu script
		scriptmenu.Pause ();
	}
}

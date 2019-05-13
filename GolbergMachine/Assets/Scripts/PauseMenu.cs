using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pausemenuUI;
	public GameObject vent;
	public AudioSource ventsound;

	void Start () {

		ventsound = vent.GetComponent<AudioSource>();
	}

		public void Pause() {
		
		//frezes time and enable UI
		pausemenuUI.SetActive (true);
		Time.timeScale = 0f;
		//Stopping backgroundsound on loop
		ventsound.Stop ();
	}
	public void Restart() {
		
		Time.timeScale = 1f;
		SceneManager.LoadScene("Machine");


	}
	public void Quit() {
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	
	}
}
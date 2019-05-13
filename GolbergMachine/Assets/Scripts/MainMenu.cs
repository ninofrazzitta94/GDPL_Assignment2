using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class MainMenu : MonoBehaviour {

	public AudioSource UISound;

	void Start(){
		
		UISound = GetComponent<AudioSource>();
	}

	public void PlayGame () {
		
		UISound.Play ();
		//Loading the "game"
		SceneManager.LoadScene ("Machine");
	}

	public void QuitGame () {
		
		// Quitting the if application was built
		Application.Quit ();
		//Closing the editor
		EditorApplication.isPlaying = false;
	}

}

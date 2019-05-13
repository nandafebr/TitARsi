using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutMenuController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void backMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

}

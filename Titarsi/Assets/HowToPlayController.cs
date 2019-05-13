using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void backMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}

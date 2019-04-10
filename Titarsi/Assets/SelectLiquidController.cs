using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLiquidController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void InstructionLabs() {
		SceneManager.LoadScene ("LabsInstruction-Step1");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabsInstructionController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void BackToSelectLiquid() {
		SceneManager.LoadScene ("SelectLiquid");
	}

	public void InstructionStep1() {
		SceneManager.LoadScene ("LabsInstruction-Step1");
	}

	public void InstructionStep2() {
		SceneManager.LoadScene ("LabsInstruction-Step2");
	}

	public void InstructionStep3() {
		SceneManager.LoadScene ("LabsInstruction-Step3");
	}

	public void StartPractice() {
		SceneManager.LoadScene ("MainARCamera");
	}
}

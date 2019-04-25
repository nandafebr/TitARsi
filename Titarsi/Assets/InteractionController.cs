using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionController : MonoBehaviour {

	public GameObject buret;

	public GameObject sphereBuret;

	public GameObject erlenmeyer;

	public GameObject sphereErlenmeyer;

	public GameObject interaction;

	void Start () {
		SetCondition (true);
	}

	void Update () {
		if (TargetBuret.Instance.terdeteksi == true) {
			if (TargetErlenmeyer.Instance.terdeteksi == true) {
				float distance = Vector3.Distance (sphereBuret.transform.position, sphereErlenmeyer.transform.position);
				if (distance < 2) {
					SetCondition (false);
				} else {
					SetCondition (true);
				}
			} else {
				SetCondition (true);
			}
		} else {
			SetCondition (true);
		}

		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene ("LabInstruction-Step3");
				return;
			}
		}
	}

	private void SetCondition(bool kondisi){
		if (kondisi) {
			buret.SetActive (true);
			erlenmeyer.SetActive (true);
			interaction.SetActive (false);
		} else {
			buret.SetActive (false);
			erlenmeyer.SetActive (false);
			interaction.SetActive (true);
		}
	}

}

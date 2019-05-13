using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour {

	public GameObject buret;

	public GameObject sphereBuret;

	public GameObject erlenmeyer;

	public GameObject sphereErlenmeyer;

	public GameObject interaction;

	public Text txt;

	public Text selesai;

	public GameObject btnTetes;

	double v1 = 0;

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
				SceneManager.LoadScene ("LabsInstruction-Step3");
				return;
			}
		}
	}

	public void hitungMolaritas(){

		double tetes = 2.5;

		double v2 = 25;
		double m1 = 0.1;
		double m2;

		v1 = v1 + tetes;

		if (v1 > 28) {
			btnTetes.SetActive (false);
			selesai.text = "Praktikum telah selesai";
		} else {
			m2 = (v1 * m1) / v2;
			txt.text = m2.ToString();
			selesai.text = "";
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour {

	public GameObject persistantObject;

	public PersistObjScript script;

	public GameObject buret;

	public GameObject sphereBuret;

	public GameObject erlenmeyer;

	public GameObject sphereErlenmeyer;

	public GameObject interaction;

	public GameObject interactionFluid;

	public Text v1;

	public Text v2;

	public Text kondimenM2;

	public Text selesai;

	public GameObject btnTetes;

	public GameObject btnCariM;

	double tetes = 2.5;

	// double v2s = 0;

	double v2ss = 25;

	double v1s;

	double m1 = 0.1;

	double m2 = 0;

	double v1awal = 0;

	public Button result;

	public GameObject playAgain;

	public GameObject exit;

	string v2s;

	void Awake(){
		persistantObject = GameObject.FindGameObjectsWithTag ("PersistantObject")[0] as GameObject;
		script = persistantObject.GetComponent<PersistObjScript> ();
		v2s = script.dataString;
		v2.text = v2s;
	}

	void Start () {
		SetCondition (false);
		// SetCondition (true);
	}

	void Update () {
		
	}

	public void hitungSelisihVolume(){

		v1awal = v1awal + tetes;
		v1s = v1awal;
		v1.text = v1awal.ToString ();

		if (v1awal >= 27.5) {
			btnTetes.SetActive (false);
			selesai.text = "Ph sudah netral";
			interaction.SetActive (false);
			interactionFluid.SetActive (true);
			result.interactable = true;
			playAgain.SetActive (true);
			exit.SetActive (true);
		} else {
			selesai.text = "";
			result.interactable = false;
			interactionFluid.SetActive (false);
			playAgain.SetActive (false);
			exit.SetActive (false);
		}

	}

	public void hitungMolaritas(){
		m2 = v1s * m1 / v2ss;
		kondimenM2.text = "M2 = " + m2.ToString ();
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

	public void playAgains(){
		SceneManager.LoadScene ("MainARCamera");
	}

	public void exitPlay(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void sliderChange(float newValue){
		
	}
}

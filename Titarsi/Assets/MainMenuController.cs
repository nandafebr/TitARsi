﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	int backCounter = 0;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			backCounter++;
			if (backCounter == 2) {
				backCounter = 0;
				Application.Quit();
			}
			showToast("Press back once again", 2);
		}
	}

	public void LiquidSelection() {
		SceneManager.LoadScene ("SelectLiquid");
	}

	public void ExitApplication() {
		Application.Quit ();
	}

	public Text txt;

	void showToast(string text, int duration) {
		StartCoroutine(showToastCOR(text, duration));
	}

	private IEnumerator showToastCOR(string text, int duration) {
		Color orginalColor = txt.color;

		txt.text = text;
		txt.enabled = true;

		yield return fadeInAndOut(txt, true, 0.5f);

		float counter = 0;
		while (counter < duration) {
			counter += Time.deltaTime;
			yield return null;
		}
			
		yield return fadeInAndOut(txt, false, 0.5f);

		txt.enabled = false;
		txt.color = orginalColor;
	}

	IEnumerator fadeInAndOut(Text targetText, bool fadeIn, float duration) {
		float a, b;
		if (fadeIn) {
			a = 0f;
			b = 1f;
		} else {
			a = 1f;
			b = 0f;
		}

		Color currentColor = Color.clear;
		float counter = 0f;

		while (counter < duration) {
			counter += Time.deltaTime;
			float alpha = Mathf.Lerp(a, b, counter / duration);

			targetText.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
			yield return null;
		}
	}
}

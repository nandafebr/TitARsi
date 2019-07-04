using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetErlenmeyer : MonoBehaviour {

	private static TargetErlenmeyer instance;

	public bool terdeteksi;

	public static TargetErlenmeyer Instance{
		get{ 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<TargetErlenmeyer> ();
			}

			return instance;
		}
	}

	void Start () {
		
	}

	void Update () {
		
	}
}

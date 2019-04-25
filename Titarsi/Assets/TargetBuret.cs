using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBuret : MonoBehaviour {

	private static TargetBuret instance;

	public bool terdeteksi;

	public static TargetBuret Instance{
		get{ 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<TargetBuret> ();
			}

			return instance;
		}
	}

	void Start () {
		
	}

	void Update () {
		
	}
}

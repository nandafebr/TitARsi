using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistObjScript : MonoBehaviour {

	public string dataString;

	void Awake(){
		DontDestroyOnLoad (this);
	}
}
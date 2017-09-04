using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DontDestroy : MonoBehaviour {
	
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}
}
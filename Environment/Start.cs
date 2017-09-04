using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Application.LoadLevel(GameInformation.currentScene);
	}
}

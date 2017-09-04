using UnityEngine;
using System.Collections;

public class ChangeSceneCavetoField : MonoBehaviour {

	void  OnCollisionEnter2D(){
		GameInformation.currentScene = "FieldAfterVillage1";
		GameInformation.spawnPoint = 7;
		Destroy (GameObject.FindWithTag ("Map")); 
		AutoFade.LoadLevel("FieldAfterVillage1" ,1,1,Color.black);
	}
}

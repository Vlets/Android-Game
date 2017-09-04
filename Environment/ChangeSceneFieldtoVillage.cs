using UnityEngine;
using System.Collections;

public class ChangeSceneFieldtoVillage : MonoBehaviour {

	void  OnCollisionEnter2D(){
		GameInformation.currentScene = "Village1";
		GameInformation.spawnPoint = 5;
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel("Village1" ,1,1,Color.black);
	}
}

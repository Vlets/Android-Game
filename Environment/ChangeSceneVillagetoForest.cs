using UnityEngine;
using System.Collections;

public class ChangeSceneVillagetoForest : MonoBehaviour {

	void  OnCollisionEnter2D(){
		GameInformation.currentScene = "ForestScene1";
		GameInformation.spawnPoint = 1;
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel("ForestScene1" ,1,1,Color.black);
	}

}

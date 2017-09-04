using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeSceneMain : MonoBehaviour {

	private DetermineNextScene nextSceneScript = new DetermineNextScene();


	void  OnCollisionEnter2D(){
		//GameInformation.currentScene = "ForestScene1";
		nextSceneScript.sceneSelect ();
		GameInformation.currentScene = GameInformation.nextScene;
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel(GameInformation.nextScene ,1,1,Color.black);
	}
	 

}

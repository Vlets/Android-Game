using UnityEngine;
using System.Collections;

public class DetermineNextScene {

public void sceneSelect(){
		if (GameInformation.currentScene == "ForestScene1") {
			GameInformation.nextScene = "Village1";
			GameInformation.spawnPoint = 1;}
		if (GameInformation.currentScene == "Village1") {
			GameInformation.nextScene = "FieldAfterVillage1";
			GameInformation.spawnPoint = 1;}
		if (GameInformation.currentScene == "FieldAfterVillage1") {
			GameInformation.nextScene = "CaveFieldAfterVillage";
			GameInformation.spawnPoint = 1;}
	} 
}

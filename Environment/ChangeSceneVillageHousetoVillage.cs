using UnityEngine;
using System.Collections;

public class ChangeSceneVillageHousetoVillage : MonoBehaviour {

	void  OnCollisionEnter2D(){
		if (GameInformation.houseExit == 1) {
			GameInformation.spawnPoint = 2;
		} 
		if(GameInformation.houseExit == 2){
			GameInformation.spawnPoint = 3;
		}
		GameInformation.houseExit = 0;
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel("Village1" ,1,1,Color.black);
	}
}

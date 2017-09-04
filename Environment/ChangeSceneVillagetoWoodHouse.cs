using UnityEngine;
using System.Collections;

public class ChangeSceneVillagetoWoodHouse : MonoBehaviour {
	

	void  OnCollisionEnter2D(){
		GameInformation.spawnPoint = 1;
		GameInformation.houseExit = 1; //house exit = wood house
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel("VillageHouseWood" ,1,1,Color.black);
	}
}

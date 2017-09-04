using UnityEngine;
using System.Collections;

public class ChangeSceneVillagetoVillageHouse : MonoBehaviour {

	void  OnCollisionEnter2D(){
		GameInformation.spawnPoint = 1;
		GameInformation.houseExit = 2;
		Destroy (GameObject.FindWithTag ("Map"));
		AutoFade.LoadLevel("VillageHouse2" ,1,1,Color.black);
	}
}

using UnityEngine;
using System.Collections;

public class ChangeSceneShop : MonoBehaviour {

	void  OnCollisionEnter2D(){
			GameInformation.spawnPoint = 4;
			AutoFade.LoadLevel("Shop" ,1,1,Color.black);
		}
}

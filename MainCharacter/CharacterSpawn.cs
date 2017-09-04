using UnityEngine;
using System.Collections;

public class CharacterSpawn : MonoBehaviour {
		
		public GameObject spawn;
		public GameObject spawn2;
		public GameObject spawn3;
		public GameObject spawn4;
		public GameObject spawn5;
		public GameObject spawn6;
		public GameObject spawn7;
		
		void Start()
		{
		if(GameInformation.spawnPoint == 1){
			transform.position = spawn.transform.position;
		}
		if(GameInformation.spawnPoint == 2){
			transform.position = spawn2.transform.position;
		}
		if(GameInformation.spawnPoint == 3){
			transform.position = spawn3.transform.position;
		}
		if(GameInformation.spawnPoint == 4){
			transform.position = spawn4.transform.position;
		}
		if(GameInformation.spawnPoint == 5){
			transform.position = spawn5.transform.position;
		}
		if(GameInformation.spawnPoint == 6){
			transform.position = spawn6.transform.position;
		}
		if(GameInformation.spawnPoint == 7){
			transform.position = spawn7.transform.position;
		}
		
	}
}
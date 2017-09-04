using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyMonsters : MonoBehaviour {
	
	void Awake(){
		if (GameInformation.monsterID == 1) {
			DestroyMonsterBandit ();
		}
		if (GameInformation.monsterID == 2) {
			DestroyMonsterSnake ();
		}
		if (GameInformation.monsterID == 3) {
			DestroyMonsterBat ();
		}
		if (GameInformation.monsterID == 4) {
			DestroyMonsterBoss ();
		}
	} 

	void DestroyMonsterBandit (){
		if (GameInformation.monsterID == 1 && GameInformation.collisionID == 1) {
			Destroy (GameObject.Find ("Bandit"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 1 && GameInformation.collisionID == 2) {
			Destroy (GameObject.Find ("Bandit2"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 1 && GameInformation.collisionID == 3) {
			Destroy (GameObject.Find ("Bandit3"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 1 && GameInformation.collisionID == 4) {
			Destroy (GameObject.Find ("Bandit4"));
			GameInformation.monsterID = 0;
		}
	}
	void DestroyMonsterSnake (){
		
		if (GameInformation.monsterID == 2 && GameInformation.collisionID == 1) {
			Destroy (GameObject.Find ("Snake"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 2 && GameInformation.collisionID == 2) {
			Destroy (GameObject.Find ("Snake2"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 2 && GameInformation.collisionID == 3) {
			Destroy (GameObject.Find ("Snake3"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 2 && GameInformation.collisionID == 4) {
			Destroy (GameObject.Find ("Snake4"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 2 && GameInformation.collisionID == 5) {
			Destroy (GameObject.Find ("Snake5"));
			GameInformation.monsterID = 0;
		}
	}
		void DestroyMonsterBat (){
		if (GameInformation.monsterID == 3 && GameInformation.collisionID == 1) {
			Destroy (GameObject.Find ("Bat"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 3 && GameInformation.collisionID == 2) {
			Destroy (GameObject.Find ("Bat2"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 3 && GameInformation.collisionID == 3) {
			Destroy (GameObject.Find ("Bat3"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 3 && GameInformation.collisionID == 4) {
			Destroy (GameObject.Find ("Bat4"));
			GameInformation.monsterID = 0;
		}
		if (GameInformation.monsterID == 3 && GameInformation.collisionID == 5) {
			Destroy (GameObject.Find ("Bat5"));
			GameInformation.monsterID = 0;
		}
	}

	void DestroyMonsterBoss (){
		if (GameInformation.monsterID == 4 && GameInformation.collisionID == 6) {
			Destroy (GameObject.Find ("Lizardron"));
			GameInformation.monsterID = 0;
		}
	}

}
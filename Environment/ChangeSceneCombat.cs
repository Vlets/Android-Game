using UnityEngine;
using System.Collections;

public class ChangeSceneCombat : MonoBehaviour {

	void  OnCollisionEnter2D(Collision2D col){
		//Bandits
		//Bandits
		if(col.gameObject.name == "Bandit")
		{
			GameInformation.collisionID = 1;
			GameInformation.monsterID = 1;
			AutoFade.LoadLevel("CombatScene" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bandit2")
		{
			GameInformation.collisionID = 2;
			GameInformation.monsterID = 1;
			AutoFade.LoadLevel("CombatScene" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bandit3")
		{
			GameInformation.collisionID = 3;
			GameInformation.monsterID = 1;
			AutoFade.LoadLevel("CombatScene" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bandit4")
		{
			GameInformation.collisionID = 4;
			GameInformation.monsterID = 1;
			AutoFade.LoadLevel("CombatScene" ,1,1,Color.black);
		}
		//Bandits
		//Bandits

		// Snakes -------------------------------------------
		// Snakes -------------------------------------------
		if(col.gameObject.name == "Snake")
		{
			GameInformation.collisionID = 1;
			GameInformation.monsterID = 2;
			AutoFade.LoadLevel("CombatSceneSnake" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Snake2")
		{
			GameInformation.collisionID = 2;
			GameInformation.monsterID = 2;
			AutoFade.LoadLevel("CombatSceneSnake" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Snake3")
		{
			GameInformation.collisionID = 3;
			GameInformation.monsterID = 2;
			AutoFade.LoadLevel("CombatSceneSnake" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Snake4")
		{
			GameInformation.collisionID = 4;
			GameInformation.monsterID = 2;
			AutoFade.LoadLevel("CombatSceneSnake" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Snake5")
		{
			GameInformation.collisionID = 5;
			GameInformation.monsterID = 2;
			AutoFade.LoadLevel("CombatSceneSnake" ,1,1,Color.black);
		}
		// Snakes -------------------------------------------
		// Snakes -------------------------------------------

		// Bat -------------------------------------------
		// Bat -------------------------------------------
		if(col.gameObject.name == "Bat")
		{
			GameInformation.collisionID = 1;
			GameInformation.monsterID = 3;
			AutoFade.LoadLevel("CombatSceneBat" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bat2")
		{
			GameInformation.collisionID = 2;
			GameInformation.monsterID = 3;
			AutoFade.LoadLevel("CombatSceneBat" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bat3")
		{
			GameInformation.collisionID = 3;
			GameInformation.monsterID = 3;
			AutoFade.LoadLevel("CombatSceneBat" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bat4")
		{
			GameInformation.collisionID = 4;
			GameInformation.monsterID = 3;
			AutoFade.LoadLevel("CombatSceneBat" ,1,1,Color.black);
		}
		if(col.gameObject.name == "Bat5")
		{
			GameInformation.collisionID = 5;
			GameInformation.monsterID = 3;
			AutoFade.LoadLevel("CombatSceneBat" ,1,1,Color.black);
		}
		// Bat -------------------------------------------
		// Bat -------------------------------------------
		if(col.gameObject.name == "Lizardron")
		{
			GameInformation.collisionID = 6;
			GameInformation.monsterID = 4;
			AutoFade.LoadLevel("CombatSceneBoss" ,1,1,Color.black);
		}
	}
} 

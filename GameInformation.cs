using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
		//this keeps the GameInfo object every time a new scene is loaded
		//this is done to store information safely 
	}

	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static int Health{ get; set; }
	public static int Mana{ get; set; }
	public static int Strength{ get; set; }
	public static int CurrentEXP{ get; set; }
	public static int RequiredEXP{ get; set; }
	public static int Coins{ get; set; } 
	public static int Speed{ get; set; }
	public static int currentHealth{ get; set; }
	public static int currentMana{ get; set; }
	public static int currentHP=1; //how many health pots the player carries right now
	public static int currentMP=1; //how many mana pots the player carries right now
	public static int spawnPoint;
	public static int houseExit;
	public static int monsterID;
	public static int collisionID;
	public static int hasSaved = 0;


	//abilities and potions
	public static BaseAbilities playerMoveOne = new Attack();
	public static BaseAbilities playerMoveTwo = new SwordSlash();
	public static BaseAbilities playerMoveThree = new Heal();
	public static BaseAbilities playerMoveFour = new DragonSlash();
	public static BasePotion healthPotion = new HealthPot();
	public static BasePotion manaPotion = new ManaPot ();


	//enemy Information
	public static string EnemyName{ get; set; }
	public static int EnemyLevel{ get; set; }
	public static int EnemyHealth{ get; set; }
	public static int EnemyMana{ get; set; }
	public static int EnemyStrength{ get; set; }
	public static int EnemySpeed{ get; set; }
	public static int currentEnemyMana{ get; set; }
	public static int currentEnemyHealth{ get; set; }

	public static string currentScene;
	public static string nextScene;
}

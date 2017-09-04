using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateNewPlayer : MonoBehaviour{
	
	private BasePlayer newPlayer;
	private string playerName = "Amno";

	void Start (){
		newPlayer = new BasePlayer ();
	}

	void Update(){
	}

	void OnGUI(){
	}

	//public void GetName(InputField nameField){
		//playerName = name;
	//	string playerName = nameField;
	//	Debug.Log (playerName);
	//}

	public void StartGame(){
		CreateNewCharacter();
		StoreNewPlayerInfo();
		AutoFade.LoadLevel("StartLoad" ,1,1,Color.black);
	}

	public void LoadsGame(){
			LoadGame.LoadInformation ();
		if (GameInformation.hasSaved == 1) {
			AutoFade.LoadLevel ("StartLoad", 1, 1, Color.black);
		}
	}

	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Health = newPlayer.Health;
		GameInformation.Mana = newPlayer.Mana;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Coins = newPlayer.Coins;
		GameInformation.Speed = newPlayer.Speed;
		GameInformation.CurrentEXP = newPlayer.CurrentEXP;
		GameInformation.currentMana = newPlayer.CurrentMana;
		GameInformation.currentHealth = newPlayer.CurrentHealth;
		GameInformation.RequiredEXP = newPlayer.RequiredEXP;
		GameInformation.currentScene = "ForestScene1";
		GameInformation.nextScene = "ForestScene1";
	}


	private void CreateNewCharacter(){
		//initialize the new character stats
		newPlayer.PlayerLevel = 1;
		newPlayer.Health = 50;
		newPlayer.Mana = 20; //Temp mana number
		newPlayer.Strength = 2; //Temp strength number
		newPlayer.PlayerName = playerName;
		newPlayer.CurrentEXP = 0;
		newPlayer.RequiredEXP = 100;
		newPlayer.Coins = 10;
		newPlayer.Speed = 2;
		newPlayer.CurrentHealth = 50;
		newPlayer.CurrentMana = 20;
		newPlayer.playerAbilities.Add (new Attack());
		newPlayer.playerAbilities.Add (new SwordSlash());
	}

}



using UnityEngine;
using System.Collections;

public class LoadGame {
	
	public static void LoadInformation(){
		GameInformation.PlayerName 	  = PlayerPrefs.GetString ("PlayerName");
		GameInformation.PlayerLevel   = PlayerPrefs.GetInt ("PlayerLevel");
		GameInformation.Health 		  = PlayerPrefs.GetInt ("Health");
		GameInformation.Mana 	      = PlayerPrefs.GetInt ("Mana");
		GameInformation.Strength 	  = PlayerPrefs.GetInt ("Strength");
		GameInformation.Coins		  = PlayerPrefs.GetInt ("Coins");
		GameInformation.Speed 		  = PlayerPrefs.GetInt ("Speed");
		GameInformation.CurrentEXP 	  = PlayerPrefs.GetInt ("CurrentEXP");
		GameInformation.hasSaved 	  = PlayerPrefs.GetInt ("hasSaved");

		GameInformation.RequiredEXP	  = PlayerPrefs.GetInt ("RequiredEXP");
		GameInformation.currentHealth = PlayerPrefs.GetInt ("CurrentHealth");
		GameInformation.currentMana	  = PlayerPrefs.GetInt ("CurrentMana");
		GameInformation.currentHP	  = PlayerPrefs.GetInt ("CurrentHP");
		GameInformation.currentMP 	  = PlayerPrefs.GetInt ("CurrentMP");
		GameInformation.houseExit 	  = PlayerPrefs.GetInt ("houseExit");
		GameInformation.currentScene  = PlayerPrefs.GetString ("currentScene");
		GameInformation.nextScene	  = PlayerPrefs.GetString ("nextScene");
		GameInformation.PlayerName	  = PlayerPrefs.GetString ("PlayerName");

	}
}

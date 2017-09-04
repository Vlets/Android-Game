using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveGame {



public static void SaveInformation(){
		PlayerPrefs.SetInt ("PlayerLevel", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt ("Health", GameInformation.Health);
		PlayerPrefs.SetInt ("Mana", GameInformation.Mana);
		PlayerPrefs.SetInt ("Strength", GameInformation.Strength);
		PlayerPrefs.SetInt ("Coins", GameInformation.Coins);
		PlayerPrefs.SetInt ("Speed", GameInformation.Speed);
		PlayerPrefs.SetInt ("CurrentEXP", GameInformation.CurrentEXP);
		PlayerPrefs.SetInt ("RequiredEXP", GameInformation.RequiredEXP);
		PlayerPrefs.SetInt ("CurrentHealth", GameInformation.currentHealth);
		PlayerPrefs.SetInt ("CurrentMana", GameInformation.currentMana);
		PlayerPrefs.SetInt ("CurrentHP", GameInformation.currentHP);
		PlayerPrefs.SetInt ("CurrentMP", GameInformation.currentMP);
		PlayerPrefs.SetInt ("houseExit", GameInformation.houseExit);
		PlayerPrefs.SetInt ("hasSaved", GameInformation.hasSaved);
		PlayerPrefs.SetString ("currentScene", GameInformation.currentScene);
		PlayerPrefs.SetString ("nextScene", GameInformation.nextScene);
		PlayerPrefs.SetString ("PlayerName", GameInformation.PlayerName);
	}
}

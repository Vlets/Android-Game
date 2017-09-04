using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusGUI : MonoBehaviour {
	
	
	private Text playerName;
	private Text playerHealth;
	private Text playerCurrentHealth;
	private Text potionOneName;
	private Text potionTwoName;
	private Text playerMana;
	private Text playerCurrentMana;
	private Text playerExp;
	private Text playerCurrentExperience;
	private Text playerLevel;
	private Text playerStrength;
	private Text playerSpeed;
	private Text playerCoins;
	private Image playerHealthImage;
	private Image playerManaImage;
	private Image playerExpImage;
	
	
	// Use this for initialization
	void Start () {
		//Display player name
		playerName = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerName").GetComponent<Text>();
		playerName.text = GameInformation.PlayerName;
		
		playerLevel = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerLevel").GetComponent<Text>();
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
		//Display max player health
		playerHealth = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerHealthValue").GetComponent<Text>();
		playerHealth.text = GameInformation.Health.ToString();
		//Display current player health
		playerCurrentHealth = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerCurrentHealth").GetComponent<Text>();
		playerHealthImage = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").GetComponent<Image>();
		//Display max player mana
		playerMana = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerManaValue").GetComponent<Text>();
		playerMana.text = GameInformation.Mana.ToString();
		//Display current player mana
		playerCurrentMana = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerCurrentMana").GetComponent<Text>();
		playerManaImage = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").GetComponent<Image>();
		//Display player Required Exp
		playerExp = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerExpValue").GetComponent<Text>();
		playerExp.text = GameInformation.RequiredEXP.ToString();
		//Display current player Exp
		playerCurrentExperience = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerCurrentExp").GetComponent<Text>();
		playerExpImage = transform.FindChild ("Menu").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").GetComponent<Image>();

		playerStrength = transform.FindChild ("Menu").FindChild ("StrengthText").GetComponent<Text>();
		playerStrength.text = (string)"Strength: " +GameInformation.Strength;

		playerSpeed = transform.FindChild ("Menu").FindChild ("SpeedText").GetComponent<Text>();
		playerSpeed.text = (string)"Speed: " +GameInformation.Speed;

		playerCoins = transform.FindChild ("Menu").FindChild ("CoinsText").GetComponent<Text>();
		playerCoins.text = (string)"Coins: " + GameInformation.Coins + "$"; 

		potionOneName = transform.FindChild ("Menu").FindChild ("HealthPotButton").FindChild ("Text").GetComponent<Text>();
		potionOneName.text = (string)"Health Potions: " + GameInformation.currentHP;

		potionTwoName = transform.FindChild ("Menu").FindChild ("ManaPotButton").FindChild ("Text").GetComponent<Text>();
		potionTwoName.text = (string)"Mana Potions: " + GameInformation.currentMP;
		//-------------------------------------------------------------------
		
	}
	
	// Update is called once per frame
	void Update () {
		//Player Information
		playerHealth.text = GameInformation.Health.ToString();
		playerMana.text = GameInformation.Mana.ToString();
		playerCurrentHealth.text = GameInformation.currentHealth.ToString();
		playerCurrentMana.text = GameInformation.currentMana.ToString();
		playerExp.text = GameInformation.RequiredEXP.ToString();
		playerCurrentExperience.text = GameInformation.CurrentEXP.ToString();
		playerHealthImage.fillAmount = (float)GameInformation.currentHealth / GameInformation.Health;
		playerManaImage.fillAmount = (float)GameInformation.currentMana / GameInformation.Mana;
		playerExpImage.fillAmount = (float)GameInformation.CurrentEXP / GameInformation.RequiredEXP;
		playerStrength.text = (string)"Strength: " +GameInformation.Strength;
		playerSpeed.text = (string)"Speed: " +GameInformation.Speed;
		playerCoins.text = (string)"Coins: " + GameInformation.Coins; 
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
		potionOneName.text = (string)"Health Potions: " + GameInformation.currentHP;
		potionTwoName.text = (string)"Mana Potions: " + GameInformation.currentMP;
	}
	
	void OnGUI(){

	}

	public void SaveInformations(){
		GameInformation.hasSaved = 1;
		SaveGame.SaveInformation();
	}

	public void HealthPotStatus(){
		if (GameInformation.currentHealth < GameInformation.Health && GameInformation.currentHP>0) {
			GameInformation.currentHealth += GameInformation.healthPotion.PotionPower;
			if(GameInformation.currentHealth > GameInformation.Health){
				GameInformation.currentHealth = GameInformation.Health;
			}
			GameInformation.currentHP -= 1;
		}

	}
	
	public void ManaPotStatus(){
		if (GameInformation.currentMana < GameInformation.Mana && GameInformation.currentMP>0) {
			GameInformation.currentMana += GameInformation.manaPotion.PotionPower;
			if(GameInformation.currentMana > GameInformation.Mana){
				GameInformation.currentMana = GameInformation.Mana;
			}
			GameInformation.currentMP -= 1;
		}

	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shop : MonoBehaviour {
	
	
	private Text playerName;
	private Text playerHealth;
	private Text playerCurrentHealth;
	private Text playerMana;
	private Text playerCurrentMana;
	private Text playerExp;
	private Text playerCurrentExperience;
	private Text playerLevel;
	private Text playerCoins;
	private Image playerHealthImage;
	private Image playerManaImage;
	private Image playerExpImage;
	
	
	// Use this for initialization
	void Start () {
		//Display player name
		playerName = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerName").GetComponent<Text>();
		playerName.text = GameInformation.PlayerName;
		
		playerLevel = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerLevel").GetComponent<Text>();
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
		//Display max player health
		playerHealth = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerHealthValue").GetComponent<Text>();
		playerHealth.text = GameInformation.Health.ToString();
		//Display current player health
		playerCurrentHealth = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerCurrentHealth").GetComponent<Text>();
		playerHealthImage = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").GetComponent<Image>();
		//Display max player mana
		playerMana = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerManaValue").GetComponent<Text>();
		playerMana.text = GameInformation.Mana.ToString();
		//Display current player mana
		playerCurrentMana = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerCurrentMana").GetComponent<Text>();
		playerManaImage = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").GetComponent<Image>();
		//Display player Required Exp
		playerExp = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerExpValue").GetComponent<Text>();
		playerExp.text = GameInformation.RequiredEXP.ToString();
		//Display current player Exp
		playerCurrentExperience = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerCurrentExp").GetComponent<Text>();
		playerExpImage = transform.FindChild ("Shop").FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").GetComponent<Image>();

		playerCoins = transform.FindChild ("Shop").FindChild ("Coins").FindChild ("Text").GetComponent<Text>();
		playerCoins.text = (string)"Coins: " + GameInformation.Coins; 
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
		playerCoins.text = (string)"Coins: " + GameInformation.Coins;
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
	}
	
	void OnGUI(){
		
	}

	public void BuyHealthPots(){
		if (GameInformation.Coins>=50) {
			GameInformation.currentHP += 1 ;
			GameInformation.Coins -= 50;
		}
	}

	public void BuyManaPots(){
		if (GameInformation.Coins>=50) {
			GameInformation.currentMP += 1 ;
			GameInformation.Coins -= 50;
		}
	}

	public void Rest(){
		if ((GameInformation.currentHealth < GameInformation.Health || GameInformation.currentMana < GameInformation.Mana) && GameInformation.Coins>=20) {
			GameInformation.currentHealth = GameInformation.Health;
			GameInformation.currentMana = GameInformation.Mana;
			GameInformation.Coins -= 20;
		}
	}

	public void Leave(){
		GameInformation.spawnPoint = 4;
		AutoFade.LoadLevel(GameInformation.currentScene ,1,1,Color.black);
	}
	
}

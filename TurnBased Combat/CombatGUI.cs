using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CombatGUI : MonoBehaviour {


	private Text playerName;
	private Text playerHealth;
	private Text playerCurrentHealth;
	private Text abilityOneName;
	private Text abilityTwoName;
	private Text potionOneName;
	private Text potionTwoName;
	private Text abilityOneDescription;
	private Text abilityTwoDescription;
	private Text playerMana;
	private Text playerCurrentMana;
	private Text playerExp;
	private Text playerCurrentExperience;
	private Text playerLevel;
	private Text CombatLog;
	private Text CombatLogEnemy;
	private Image playerHealthImage;
	private Image playerManaImage;
	private Image playerExpImage;

	//-------------------------------Enemy Info----------
	private Text enemyName;
	private Text enemyHealth;
	private Text enemyCurrentHealth;
	private Text enemyMana;
	private Text enemyCurrentMana;
	private Text enemyLevel;
	private Image enemyHealthImage;
	private Image enemyManaImage;

	public static int RandomDamage;

	// Use this for initialization
	void Start () {
		//Display player name
		playerName = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerName").GetComponent<Text>();
		playerName.text = GameInformation.PlayerName;

		playerLevel = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerIcon").FindChild ("PlayerLevel").GetComponent<Text>();
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
		//Display max player health
		playerHealth = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerHealthValue").GetComponent<Text>();
		playerHealth.text = GameInformation.Health.ToString();
		//Display current player health
		playerCurrentHealth = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").FindChild ("PlayerCurrentHealth").GetComponent<Text>();
		playerHealthImage = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerHealth").GetComponent<Image>();
		//Display max player mana
		playerMana = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerManaValue").GetComponent<Text>();
		playerMana.text = GameInformation.Mana.ToString();
		//Display current player mana
		playerCurrentMana = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").FindChild ("PlayerCurrentMana").GetComponent<Text>();
		playerManaImage = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerMana").GetComponent<Image>();
		//Display player Required Exp
		playerExp = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerExpValue").GetComponent<Text>();
		playerExp.text = GameInformation.RequiredEXP.ToString();
		//Display current player Exp
		playerCurrentExperience = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").FindChild ("PlayerCurrentExp").GetComponent<Text>();
		playerExpImage = transform.FindChild ("PlayerInfoContainer").FindChild ("PlayerExp").GetComponent<Image>();
		//Combat Log
		CombatLog = transform.FindChild("CombatLog").FindChild ("Log").GetComponent<Text>();
		CombatLog.text = (string)"Combat Start!";

		CombatLogEnemy = transform.FindChild("CombatLog").FindChild ("EnemyLog").GetComponent<Text>();
		CombatLogEnemy.text = (string)"Choose your move.";
		//-------------------------------------------------------------------
		//Display enemy name
		enemyName = transform.FindChild ("EnemyInfoContainer").FindChild ("EnemyIcon").FindChild ("EnemyName").GetComponent<Text>();
		enemyName.text = GameInformation.EnemyName;
		//display enemy level
		enemyLevel = transform.FindChild ("EnemyInfoContainer").FindChild ("EnemyIcon").FindChild ("EnemyLevel").GetComponent<Text>();
		enemyLevel.text = (string)"Lvl: " + GameInformation.EnemyLevel.ToString();
		//Display max enemy health
		enemyHealth = transform.FindChild ("EnemyInfoContainer").FindChild ("EnemyHealth").FindChild ("EnemyHealthValue").GetComponent<Text>();
		enemyHealth.text = GameInformation.EnemyHealth.ToString();
		//Display current enemy health
		enemyCurrentHealth = transform.FindChild ("EnemyInfoContainer").FindChild ("EnemyHealth").FindChild ("EnemyCurrentHealth").GetComponent<Text>();
		//enemyCurrentHealth.text = GameInformation.currentEnemyHealth.ToString();
		enemyHealthImage = transform.FindChild ("EnemyInfoContainer").FindChild ("EnemyHealth").GetComponent<Image>();

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
		playerLevel.text = (string)"Lvl: " + GameInformation.PlayerLevel.ToString (); 
		//enemy attack log
		if (TBCStateMachine.currentState == TBCStateMachine.BattleStates.ENDTURN) {
			CombatLogEnemy.text = (string)"Enemy used " + TBCStateMachine.enemyUsedAbility.AbilityName + (string)"! It dealt " + 
				CombatCalculations.totalUsedAbilityDamageGUI + (string)" Damage!";
		}
		//Enemy Information
		enemyName.text = GameInformation.EnemyName;
		enemyHealth.text = GameInformation.EnemyHealth.ToString();
		enemyCurrentHealth.text = GameInformation.currentEnemyHealth.ToString();
		//add if to ensure that if it goes below 0 it will always be empty
		enemyLevel.text = (string)"Lvl: " + GameInformation.EnemyLevel.ToString();
		enemyHealthImage.fillAmount = (float)GameInformation.currentEnemyHealth / GameInformation.EnemyHealth;

		potionOneName.text = GameInformation.healthPotion.PotionName +(string)" x" + GameInformation.currentHP.ToString (); 
		potionTwoName.text = GameInformation.manaPotion.PotionName +(string)" x" + GameInformation.currentMP.ToString (); 
	}

	void OnGUI(){
		//if (TBCStateMachine.currentState == TBCStateMachine.BattleStates.PLAYERCHOICE) {
		//}
	}

	public void AbilityOne(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			TBCStateMachine.playerUsedAbility = GameInformation.playerMoveOne;
			TBCStateMachine.hasPlayerAttacked = true;
			RandomDamage = Random.Range (4, 15);
			if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost >= 0) {
				TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
				CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedAbility.AbilityName + (string)"! It dealt " + 
					(TBCStateMachine.playerUsedAbility.AbilityPower + GameInformation.Strength * 2 + RandomDamage) + (string)" Damage!";
			}
		}
	}


	public void AbilityTwo(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			TBCStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
			RandomDamage = Random.Range (4, 15);
			if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost >= 0) {
				TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
				CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedAbility.AbilityName + (string)"! It dealt " +
					(TBCStateMachine.playerUsedAbility.AbilityPower + GameInformation.Strength * 2 + RandomDamage) + (string)" Damage!";
			}
			if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost < 0) {
				CombatLog.text = (string)"Not enough Mana! " + TBCStateMachine.playerUsedAbility.AbilityName + (string)" costs " +
					TBCStateMachine.playerUsedAbility.AbilityCost + " Mana!";
			}
		}
	} 

	public void AbilityThree(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			if (GameInformation.PlayerLevel >= 3) {
				TBCStateMachine.playerUsedAbility = GameInformation.playerMoveThree;

				if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost >= 0) {
					TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
					CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedAbility.AbilityName + (string)"! You healed for " +
						(TBCStateMachine.playerUsedAbility.AbilityPower + GameInformation.PlayerLevel * 2) + " Health!";
				}
				if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost < 0) {
					CombatLog.text = (string)"Not enough Mana! " + TBCStateMachine.playerUsedAbility.AbilityName + (string)" costs " +
						TBCStateMachine.playerUsedAbility.AbilityCost + " Mana!";
				}
			}
		}
	}

	public void AbilityFour(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			if (GameInformation.PlayerLevel >= 10) {
				TBCStateMachine.playerUsedAbility = GameInformation.playerMoveFour;
				RandomDamage = Random.Range (4, 15);
				if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost >= 0) {
					TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
					CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedAbility.AbilityName + (string)"! It dealt " +
						(TBCStateMachine.playerUsedAbility.AbilityPower + GameInformation.Strength * 2 + RandomDamage) + (string)" Damage!";
				}
				if (GameInformation.currentMana - TBCStateMachine.playerUsedAbility.AbilityCost < 0) {
					CombatLog.text = (string)"Not enough Mana! " + TBCStateMachine.playerUsedAbility.AbilityName + (string)" costs " +
						TBCStateMachine.playerUsedAbility.AbilityCost + " Mana!";
				}
			}
		}
	} 

	public void HealthPot(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			if (GameInformation.currentHealth < GameInformation.Health && GameInformation.currentHP > 0) {
				TBCStateMachine.playerUsedPotion = GameInformation.healthPotion;
				TBCStateMachine.usedPotion = true;
				TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
				CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedPotion.PotionName + (string)"! You restored " + TBCStateMachine.playerUsedPotion.PotionPower + (string)" Health!";
			}
			if (GameInformation.currentHealth == GameInformation.Health && GameInformation.currentHP > 0) {
				CombatLog.text = (string)"You are already at Max Health!";
			}
			if (GameInformation.currentHP == 0) {
				CombatLog.text = (string)"You have no more " + TBCStateMachine.playerUsedPotion.PotionName + (string)"s!";
			}
		}
	}

	public void ManaPot(){
		if (!TBCStateMachine.hasPlayerAttacked) {
			if (GameInformation.currentMana < GameInformation.Mana && GameInformation.currentMP > 0) {
				TBCStateMachine.playerUsedPotion = GameInformation.manaPotion;
				TBCStateMachine.usedPotion = true;
				TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
				CombatLog.text = (string)"You used " + TBCStateMachine.playerUsedPotion.PotionName + (string)"! You restored " + TBCStateMachine.playerUsedPotion.PotionPower + (string)" Mana!";
			}
			if (GameInformation.currentMana == GameInformation.Mana && GameInformation.currentMP > 0) {
				CombatLog.text = (string)"You are already at Max Mana!";
			}
			if (GameInformation.currentMP == 0) {
				CombatLog.text = (string)"You have no more " + TBCStateMachine.playerUsedPotion.PotionName + (string)"s!";
			}
		}
	}

	public void Run(){
		TBCStateMachine.currentState = TBCStateMachine.BattleStates.RUN;
	}

	public void FindAbilityOneInfo(){ 
		abilityOneName = transform.FindChild ("Abilities").FindChild ("AbilitiesContainer").FindChild ("A1").FindChild ("AbilityOne").GetComponent<Text>();
		abilityOneName.text = GameInformation.playerMoveOne.AbilityName;
		//abilityOneDescription = transform.FindChild ("Abilities").FindChild ("Description").GetComponent<Text>();
		//abilityOneDescription.text = GameInformation.playerMoveOne.AbilityDescription;
	}

	public void FindAbilityTwoInfo(){
		abilityTwoName = transform.FindChild ("Abilities").FindChild ("AbilitiesContainer").FindChild ("A2").FindChild ("AbilityTwo").GetComponent<Text>();
		abilityTwoName.text = GameInformation.playerMoveTwo.AbilityName;
		//abilityTwoDescription = transform.FindChild ("Abilities").FindChild ("Description").GetComponent<Text>();
		//abilityTwoDescription.text = GameInformation.playerMoveTwo.AbilityDescription;
	}

	public void FindAbilityThreeInfo(){
		if (GameInformation.PlayerLevel >= 3) {
			abilityTwoName = transform.FindChild ("Abilities").FindChild ("AbilitiesContainer").FindChild ("A3").FindChild ("AbilityThree").GetComponent<Text> ();
			abilityTwoName.text = GameInformation.playerMoveThree.AbilityName;
		}
	}

	public void FindAbilityFourInfo(){
		if (GameInformation.PlayerLevel >= 10) {
			abilityTwoName = transform.FindChild ("Abilities").FindChild ("AbilitiesContainer").FindChild ("A4").FindChild ("AbilityFour").GetComponent<Text> ();
			abilityTwoName.text = GameInformation.playerMoveFour.AbilityName;
		}
	}

	public void FindPotionOneInfo(){ 
		potionOneName = transform.FindChild ("Abilities").FindChild ("PotionsContainer").FindChild ("P1").FindChild ("PotionOne").GetComponent<Text>();
		potionOneName.text = GameInformation.healthPotion.PotionName +(string)" x" + GameInformation.currentHP.ToString (); 

	}
	
	public void FindPotionTwoInfo(){
		potionTwoName = transform.FindChild ("Abilities").FindChild ("PotionsContainer").FindChild ("P2").FindChild ("PotionTwo").GetComponent<Text>();
		potionTwoName.text = GameInformation.manaPotion.PotionName +(string)"  x" + GameInformation.currentMP.ToString (); 

	}


}

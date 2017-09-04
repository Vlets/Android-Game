using UnityEngine;
using System.Collections;


public class CombatCalculations {

	//private StatCalculations statCalcScript = new StatCalculations();
	private int abilityPower;
	private float totalAbilityPowerDamage;
	private int totalUsedAbilityDamage;
	public static int totalUsedAbilityDamageGUI;
	private CombatGUI enemyLog = new CombatGUI ();

	public void calculatePlayerMoveDamage(BaseAbilities usedAbility){
		Debug.Log ("Used Ability: " + usedAbility.AbilityName);
		//Used Ability Power + Player Strength*2 + Random Damage(Ranging from 4 to 15)
		totalUsedAbilityDamage = (int)CalculateAbilityDamage (usedAbility) + GameInformation.Strength*2  + CombatGUI.RandomDamage;

		GameInformation.currentMana -= usedAbility.AbilityCost; //Lose mana equal to the ability cost

		if (usedAbility.AbilityName != "Heal") {
			GameInformation.currentEnemyHealth -= totalUsedAbilityDamage; 
		}
		if (usedAbility.AbilityName == "Heal") {
			GameInformation.currentHealth += usedAbility.AbilityPower + GameInformation.PlayerLevel*2;
			if(GameInformation.currentHealth > GameInformation.Health){
				GameInformation.currentHealth = GameInformation.Health;
			}
		}
		TBCStateMachine.playerCompletedTurn = true;

	} 

	public void calculateEnemyMoveDamage(BaseAbilities usedAbility){
		Debug.Log ("Used Ability: " + usedAbility.AbilityName);
		//Used Ability Power + Enemy Strength + Random Damage(Ranging from 1 to 3)*EnemyLevel
		totalUsedAbilityDamage = (int)CalculateAbilityDamage (usedAbility) + GameInformation.EnemyStrength + Random.Range(1,3)*GameInformation.EnemyLevel;
		GameInformation.currentEnemyMana -= usedAbility.AbilityCost; //Lose mana equal to the ability cost
		TBCStateMachine.enemyCompletedTurn = true;
		totalUsedAbilityDamageGUI = totalUsedAbilityDamage;

		if (usedAbility.AbilityName != "Heal") {
			GameInformation.currentHealth -= totalUsedAbilityDamage;
		}
		if (usedAbility.AbilityName == "Heal") {
			GameInformation.currentEnemyHealth += usedAbility.AbilityPower + GameInformation.EnemyLevel;
			if(GameInformation.currentEnemyHealth > GameInformation.EnemyHealth){
				GameInformation.currentEnemyHealth = GameInformation.EnemyHealth;
			}
		}
	}

	public void calculatePlayerRegeneration (BasePotion playerUsedPotion){
		if(playerUsedPotion.PotionName == "Health Potion"){
			GameInformation.currentHealth += playerUsedPotion.PotionPower;
			if(GameInformation.currentHealth > GameInformation.Health){
				GameInformation.currentHealth = GameInformation.Health;
			}
			GameInformation.currentHP -= 1;
		}
		if(playerUsedPotion.PotionName == "Mana Potion"){ 
			GameInformation.currentMana += playerUsedPotion.PotionPower;
			if(GameInformation.currentMana > GameInformation.Mana){
				GameInformation.currentMana = GameInformation.Mana;
			}
			GameInformation.currentMP -= 1;
		}
		TBCStateMachine.playerCompletedTurn = true;
	}

	private float CalculateAbilityDamage(BaseAbilities usedAbility){
		abilityPower = usedAbility.AbilityPower; //retrieves ability power of move used
		totalAbilityPowerDamage = abilityPower;
		return totalAbilityPowerDamage;
	}

}

using UnityEngine;
using System.Collections;

public class EnemyAbilityChoice {

	public static BaseAbilities enemyAbilityOne;
	private int playerHealthPercentage;
	private int enemyHealthPercentage;
	private BaseAbilities chosenAbility;

	public BaseAbilities ChooseEnemyAbility(){
		playerHealthPercentage = (GameInformation.currentHealth / GameInformation.Health)*100;
		enemyHealthPercentage = (GameInformation.currentEnemyHealth / GameInformation.EnemyHealth) * 100;
		enemyAbilityOne = GameInformation.playerMoveOne;
		if (GameInformation.monsterID != 1) {
			if (playerHealthPercentage >= 75) {
				return chosenAbility = new Tackle ();
			} else if (playerHealthPercentage < 75 && playerHealthPercentage >= 50) {
				return chosenAbility = new Attack ();
			} else if (playerHealthPercentage < 50) {
				return chosenAbility = new Attack ();
			} else {
				return chosenAbility = new Attack ();
			}
		} else if (GameInformation.monsterID == 1) {
			if (playerHealthPercentage >= 75) {
				return chosenAbility = new SwordSlash ();
			} else if (playerHealthPercentage < 75 && playerHealthPercentage >= 50) {
				return chosenAbility = new Attack ();
			} else if (playerHealthPercentage < 50) {
				return chosenAbility = new Attack ();
			} else {
				return chosenAbility = new Attack ();
			}
		} else {
			return chosenAbility = new Attack ();
		}
	}

}

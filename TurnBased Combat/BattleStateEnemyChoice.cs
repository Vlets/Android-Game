using UnityEngine;
using System.Collections;

public class BattleStateEnemyChoice {

	private EnemyAbilityChoice enemyAbilityChoiceScript = new EnemyAbilityChoice();

	public void EnemyEndTurn(){
		//choose ability
		TBCStateMachine.enemyUsedAbility = enemyAbilityChoiceScript.ChooseEnemyAbility();
		Debug.Log ("Enemy Choice " + TBCStateMachine.enemyUsedAbility.AbilityName);
		//calculate damage
		TBCStateMachine.currentState = TBCStateMachine.BattleStates.CALCPLAYERDAMAGE;
		//end turn

	}

}

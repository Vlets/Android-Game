using UnityEngine;
using System.Collections;

public class BattleStateEndTurn {
	
	public void EndTurn(){
		TBCStateMachine.turnCount += 1;
		TBCStateMachine.usedPotion = false;
		TBCStateMachine.playerCompletedTurn = false;
		TBCStateMachine.enemyCompletedTurn = false;
	}


}

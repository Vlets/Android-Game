using UnityEngine;
using System.Collections;

public class CombatEnd {

	public void findSpawnPoint(){
		if (GameInformation.collisionID == 1) {
			GameInformation.spawnPoint=2;
		}
		if (GameInformation.collisionID == 2) {
			GameInformation.spawnPoint=3;
		}
		if (GameInformation.collisionID == 3) {
			GameInformation.spawnPoint=4;
		}
		if (GameInformation.collisionID == 4) {
			GameInformation.spawnPoint=5;
		}
		if (GameInformation.collisionID == 5) {
			GameInformation.spawnPoint=6;
		}
		if (GameInformation.collisionID == 6) {
			GameInformation.spawnPoint=7;
		}
	}

	public void WinCombat(){
		TBCStateMachine.playerCompletedTurn = false;
		TBCStateMachine.enemyCompletedTurn = false;
		TBCStateMachine.usedPotion = false;
		TBCStateMachine.hasPlayerAttacked = false;
	}

	public void LoseCombat(){
		GameInformation.currentHealth = 1;
		TBCStateMachine.playerCompletedTurn = false;
		TBCStateMachine.enemyCompletedTurn = false;
		TBCStateMachine.usedPotion = false;
		TBCStateMachine.hasPlayerAttacked = false;
	}
}

using UnityEngine;
	using System.Collections;

	public class BattleStateStart
	{

	//private StatCalculations statCalculationsScript = new StatCalculations();
	public BasePlayer newEnemy = new BasePlayer ();
	private string[] EnemyNames = new string[] {
		"Bandit",
		"Snake"
	};

	public void PrepareBattle(){
		//create enemy
		CreateNewEnemy();
		//Store Enemy info
		StoreNewEnemyInfo ();
		//choose who goes first based on speed.
		WhoGoesFirst ();
	}

	    

private void CreateNewEnemy(){
		if (GameInformation.monsterID == 1) {
			newEnemy.PlayerName = "Bandit";
			newEnemy.PlayerLevel = Random.Range (1, 4);
			newEnemy.Health = Random.Range (30, 60);
			newEnemy.Strength = Random.Range (0, 3);

		}
		if (GameInformation.monsterID == 2) {
			newEnemy.PlayerName = "Snake";
			newEnemy.PlayerLevel = Random.Range (5, 9);
			newEnemy.Health = Random.Range (100, 180);
			newEnemy.Strength = Random.Range (5, 8);
		}
		if (GameInformation.monsterID == 3) {
			newEnemy.PlayerName = "Bat";
			newEnemy.PlayerLevel = Random.Range (GameInformation.PlayerLevel, GameInformation.PlayerLevel + 2);
			newEnemy.Health = Random.Range (GameInformation.Health - 20, GameInformation.Health + 20);
			newEnemy.Strength = Random.Range (GameInformation.Strength - 2, GameInformation.Strength);
		}
		if (GameInformation.monsterID == 4) {
			newEnemy.PlayerName = "Lizardron";
			newEnemy.PlayerLevel = 15;
			newEnemy.Health = 500;
			newEnemy.Strength = 12;
		}
		newEnemy.Speed = 1;
		newEnemy.Mana = 10000;
}

private void StoreNewEnemyInfo(){
		GameInformation.EnemyName = newEnemy.PlayerName;
		GameInformation.EnemyLevel = newEnemy.PlayerLevel;
		GameInformation.EnemyHealth = newEnemy.Health;
		GameInformation.EnemyMana = newEnemy.Mana;
		GameInformation.EnemyStrength = newEnemy.Strength;
		GameInformation.EnemySpeed = newEnemy.Speed;
		GameInformation.currentEnemyMana = newEnemy.Mana;
		GameInformation.currentEnemyHealth = newEnemy.Health;
}

	public void WhoGoesFirst(){
		if (GameInformation.Speed >= GameInformation.EnemySpeed) {
			//Player goes first
			TBCStateMachine.currentState = TBCStateMachine.BattleStates.PLAYERCHOICE;
		}
		if (GameInformation.Speed < GameInformation.EnemySpeed) {
			//enemy goes first
			TBCStateMachine.currentState = TBCStateMachine.BattleStates.ENEMYCHOICE;
		}
	}

}
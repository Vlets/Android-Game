using UnityEngine;
using System.Collections;

public class TBCStateMachine : MonoBehaviour {

	private bool hasAddedEXP = false;
	private bool hasAddedCoins = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();
	private CombatCalculations combatCalcScript = new CombatCalculations();
	private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice();
	private BattleStateEndTurn battleStateEndTurnScript = new BattleStateEndTurn();
	private CombatEnd combatEndScript = new CombatEnd ();
	public static BaseAbilities enemyUsedAbility;
	public static BaseAbilities playerUsedAbility;
	public static BasePotion playerUsedPotion;
	public static int turnCount;
	public static int delayCount=0;
	public static bool playerCompletedTurn;
	public static bool enemyCompletedTurn;
	public static bool usedPotion = false;
	public static bool hasPlayerAttacked = false;
	public static BattleStates currentUser; //enemy or player choice

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		CALCPLAYERDAMAGE,
		DELAY,
		ENDTURN,
		LOSE,
		WIN,
		RUN
	}

	public static BattleStates currentState;


	void Start () {
		hasAddedEXP = false;
		turnCount = 1;
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch (currentState) 
		{
		case (BattleStates.START):
			battleStateStartScript.PrepareBattle();
			break;

		case (BattleStates.PLAYERCHOICE): 
			//this state is entered from CombatGUI script
			currentUser = BattleStates.PLAYERCHOICE;
			break;

		case (BattleStates.ENEMYCHOICE): 
			currentUser = BattleStates.ENEMYCHOICE;
			battleStateEnemyChoiceScript.EnemyEndTurn();
			break; 
	
		case (BattleStates.CALCPLAYERDAMAGE):
			//go into combat calculation script and calculate damage done
			if (currentUser == BattleStates.PLAYERCHOICE && !usedPotion){
				combatCalcScript.calculatePlayerMoveDamage(playerUsedAbility);}
			if (currentUser == BattleStates.PLAYERCHOICE && usedPotion){
				combatCalcScript.calculatePlayerRegeneration(playerUsedPotion);}
			if (currentUser == BattleStates.ENEMYCHOICE){
				combatCalcScript.calculateEnemyMoveDamage(enemyUsedAbility);}
			WhoChoosesNext();
			break;

		case (BattleStates.DELAY):
			if(delayCount < 60)
			{
				delayCount += 1;
			}
			if(delayCount >=60)
			{
				delayCount = 0;
				if(playerCompletedTurn && !enemyCompletedTurn){
					//enemy turn
					currentState = BattleStates.ENEMYCHOICE;
				}
				if(!playerCompletedTurn && enemyCompletedTurn){
					//player turn
					currentState = BattleStates.PLAYERCHOICE;
				}
			}
			break;

		case (BattleStates.ENDTURN): 
				hasPlayerAttacked = false;
				battleStateEndTurnScript.EndTurn();
				battleStateStartScript.WhoGoesFirst();
			break;

		case (BattleStates.WIN): 
				if(!hasAddedEXP){
					GainExp.GainExperience();
					hasAddedEXP = true;
				}
				if(!hasAddedCoins){
					GameInformation.Coins += Random.Range(3, 30);
					hasAddedCoins = true;
				}
			GameInformation.currentEnemyHealth = 0;
			combatEndScript.WinCombat();
			combatEndScript.findSpawnPoint();
			Debug.Log ("Player Coins:" + GameInformation.Coins);
			Destroy (GameObject.FindWithTag ("Map"));
			AutoFade.LoadLevel(GameInformation.currentScene ,1,1,Color.black);
			break;

		case (BattleStates.LOSE): 
			combatEndScript.LoseCombat();
			combatEndScript.findSpawnPoint();
			Destroy (GameObject.FindWithTag ("Map"));
			AutoFade.LoadLevel("GameOver" ,1,1,Color.red);
			break;

		case (BattleStates.RUN): 
			playerCompletedTurn = false;
			enemyCompletedTurn = false;
			usedPotion = false;
			hasPlayerAttacked = false;
			combatEndScript.findSpawnPoint();
			Destroy (GameObject.FindWithTag ("Map"));
			AutoFade.LoadLevel(GameInformation.currentScene ,1,1,Color.black);
			break;
		}
	}

	private void WhoChoosesNext(){ 
		if(playerCompletedTurn && enemyCompletedTurn){
			//end turn
			currentState = BattleStates.ENDTURN;
		}
		if(playerCompletedTurn && !enemyCompletedTurn){
			//enemy turn
			currentState = BattleStates.DELAY;
		}
		if(!playerCompletedTurn && enemyCompletedTurn){
			//player turn
			currentState = BattleStates.DELAY;
		}
		if(GameInformation.currentHealth <= 0){
			currentState = BattleStates.LOSE;
		}
		
		if(GameInformation.currentEnemyHealth <= 0){
			currentState = BattleStates.WIN;
		}
	}

}

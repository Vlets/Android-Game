using UnityEngine;
using System.Collections;

public static class GainExp {

	private static int expToGive;
	private static LevelUP levelUPScript = new LevelUP();

	public static void GainExperience(){
		expToGive = (GameInformation.EnemyLevel * 40)*GameInformation.PlayerLevel;
		GameInformation.CurrentEXP += expToGive;
		CheckIfLevelUP ();

		}


	private static void CheckIfLevelUP(){
		if (GameInformation.CurrentEXP >= GameInformation.RequiredEXP) 
		{
		//level up
		levelUPScript.LevelUpPlayer();
		}
	}
}

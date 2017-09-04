using UnityEngine;
using System.Collections;

public class LevelUP {
	
	public void LevelUpPlayer(){
		if (GameInformation.CurrentEXP > GameInformation.RequiredEXP) {
			GameInformation.CurrentEXP -= GameInformation.RequiredEXP;
		} else {
			GameInformation.CurrentEXP = 0;
		}
		GameInformation.RequiredEXP *= 2;
		GameInformation.PlayerLevel += 1;
		//give stats
		GameInformation.Health += 10;
		GameInformation.currentHealth += 10;
		GameInformation.Mana += Random.Range (5, 10);
		GameInformation.currentMana += Random.Range (5, 10);
		GameInformation.Strength += Random.Range (0, 4);
		GameInformation.Speed += Random.Range (0, 3);
		//give ability
	}

}

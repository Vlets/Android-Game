using UnityEngine;
using System.Collections;
[System.Serializable]
public class ManaPot : BasePotion {
	
	public ManaPot(){
		PotionName = "Mana Potion";
		PotionDescription = "Restores 10 Mana";
		PotionID = 2;
		PotionPower = 10;
	}
}

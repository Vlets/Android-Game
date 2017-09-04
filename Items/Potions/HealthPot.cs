using UnityEngine;
using System.Collections;
[System.Serializable]
public class HealthPot : BasePotion {
	
	public HealthPot(){
		PotionName = "Health Potion";
		PotionDescription = "Restores 20HP";
		PotionID = 1;
		PotionPower = 20;
	}
}

using UnityEngine;
using System.Collections;
[System.Serializable]
public class Heal : BaseAbilities {
	
	public Heal(){
		AbilityName = "Heal";
		AbilityDescription = "Heals the user slightly";
		AbilityID = 3;
		AbilityPower = 10;
		AbilityCost = 5;
	}
}

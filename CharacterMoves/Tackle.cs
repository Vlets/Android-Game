using UnityEngine;
using System.Collections;
[System.Serializable]
public class Tackle : BaseAbilities {
	
	public Tackle(){
		AbilityName = "Tackle";
		AbilityDescription = "A powerful Tackle.";
		AbilityID = 5;
		AbilityPower = 10;
		AbilityCost = 0;
	}
}

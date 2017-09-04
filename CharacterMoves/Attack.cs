using UnityEngine;
using System.Collections;
[System.Serializable]
public class Attack : BaseAbilities {

	public Attack(){
		AbilityName = "Attack";
		AbilityDescription = "Swing your weapon to the enemy.";
		AbilityID = 1;
		AbilityPower = 1;
		AbilityCost = 0;
}
}

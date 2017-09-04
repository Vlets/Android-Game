using UnityEngine;
using System.Collections;

public class DragonSlash : BaseAbilities {
	
	public DragonSlash(){
		AbilityName = "Dragon Slash";
		AbilityDescription = "Burns the enemy with a ferocious flame";
		AbilityID = 4;
		AbilityPower = 50;
		AbilityCost = 40;
	}
}

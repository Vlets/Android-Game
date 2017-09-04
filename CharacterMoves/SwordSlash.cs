using UnityEngine;
using System.Collections;
[System.Serializable]
public class SwordSlash : BaseAbilities {

	public SwordSlash(){
		AbilityName = "Sword Slash";
		AbilityDescription = "A powerful slash from your sword.";
		AbilityID = 2;
		AbilityPower = 10;
		AbilityCost = 10;
}
}

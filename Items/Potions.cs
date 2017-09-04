using UnityEngine;
using System.Collections;

public class Potions : ItemStats {
	
	public enum PotionTypes{
		HEALTH,
		MANA,
		FULL
	}
	
	private PotionTypes potionType;
	private int spellEffectID;
	
	public PotionTypes PotionType{
		get{return potionType;}
		set{potionType = value;}
	}
	
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
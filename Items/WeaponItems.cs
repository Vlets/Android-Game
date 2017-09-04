using UnityEngine;
using System.Collections;

public class WeaponItems : ItemStats 
	{
	public enum WeaponTypes
	{
		SWORD,
		STAFF
	}
	private WeaponTypes weaponType;
	private int spellEffectID;
	
	public WeaponTypes WeaponType{
		get{return weaponType;}
		set{weaponType = value;}
	}
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
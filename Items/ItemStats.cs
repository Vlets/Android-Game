using UnityEngine;
using System.Collections;

public class ItemStats : BaseItem {

	private int health;
	private int strength;
	private int mana;

	public int Strength{ //Public is with capitalized 1st letter
		get {return strength;} //returning same name but small letter
		set {strength = value;}
	}
	public int Mana{
		get {return mana;}
		set {mana = value;}
	}
	public int Health{
		get {return health;}
		set {health = value;}
	}
}
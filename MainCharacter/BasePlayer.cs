using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BasePlayer{
		
	private string playerName;
	private int playerLevel;
	private int health;
	private int mana;
	private int strength;
	private int currentEXP;
	private int requiredEXP = 100;
	private int coins;
	private int speed;
	private int currentHealth;
	private int currentMana;
	public  List<BaseAbilities> playerAbilities = new List<BaseAbilities>();

	public BasePlayer(){
	}

	public string PlayerName{
		get{return playerName;}
		set{playerName = value;}
	}

	public int Speed{
		get{return speed;}
		set{speed = value;}
	}

	public int CurrentHealth{
		get{return currentHealth;}
		set{currentHealth = value;}
	}

	public int CurrentMana{
		get{return currentMana;}
		set{currentMana = value;}
	}

	public int Coins{
		get{return coins;}
		set{coins = value;}
	}
	
	public int CurrentEXP {
		get{ return currentEXP;}
		set{ currentEXP = value;}
	}

	public int RequiredEXP {
		get{ return requiredEXP;}
		set{ requiredEXP = value;}
	}

	public int PlayerLevel{
		get{return playerLevel;}
		set{playerLevel = value;}
	}

	public int Health{
		get{return health;}
		set{health = value;}
	}

	public int Mana{
		get{return mana;}
		set{mana = value;}
	}

	public int Strength{
		get{return strength;}
		set{strength = value;}
	}

}



[System.Serializable]
public class BaseAbilities {

	private string abilityName;
	private string abilityDescription;
	private int abilityID;
	private int abilityPower;
	private int abilityCost;

	public string AbilityName{ 
		get{return abilityName;}
		set{abilityName = value;}
	} 

	public string AbilityDescription{ 
		get{return abilityDescription;}
		set{abilityDescription = value;}
	} 

	public int AbilityID{ 
		get{return abilityID;}
		set{abilityID = value;}
	} 

	public int AbilityPower{ 
		get{return abilityPower;}
		set{abilityPower = value;}
	} 

	public int AbilityCost{ 
		get{return abilityCost;}
		set{abilityCost = value;}
	} 

}

[System.Serializable]
public class BasePotion {
	
	private string potionName;
	private string potionDescription;
	private int potionID;
	private int potionPower;
	
	public string PotionName{ 
		get{return potionName;}
		set{potionName = value;}
	} 
	
	public string PotionDescription{ 
		get{return potionDescription;}
		set{potionDescription = value;}
	} 
	
	public int PotionID{ 
		get{return potionID;}
		set{potionID = value;}
	} 
	
	public int PotionPower{ 
		get{return potionPower;}
		set{potionPower = value;}
	} 

	
}

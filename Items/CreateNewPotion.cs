using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {
	
	private Potions newPotion;
	//This string array holds the names of the potions depending on strength
	//private string[] PotionNames = new string[3] {
	//	"Greater",
	//	"Supreme",
	//	"Max"
	//};
	
	void Start (){
		CreatePotion ();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType);
	}
	
	public void CreatePotion(){
		
		newPotion = new Potions ();
		//create description
		newPotion.ItemDescription = "Restores your Health/Mana";
		//Potion ID
		newPotion.ItemID = Random.Range (1, 101);
		//Potion type
		ChoosePotionType ();
	}
	
	private void ChoosePotionType(){
		int randomTempPot = Random.Range (0, 2);
		Debug.Log (randomTempPot);
		switch (randomTempPot) {
		case 0:
			newPotion.PotionType = Potions.PotionTypes.HEALTH;
			newPotion.ItemName = "Health Potion";
			break;
		case 1:
			newPotion.PotionType = Potions.PotionTypes.MANA;
			newPotion.ItemName = "Mana Potion";
			break;
		default:
			break;
		}
	}
}
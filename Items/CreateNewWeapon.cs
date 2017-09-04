using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private WeaponItems newWeapon;
	//This string array holds the names of the weapons
	private string[] SwordNames = new string[4] {
		"Dragon Blade",
		"Iron Sword",
		"Double Edged Sword",
		"Steel Sword"
	};
	private string[] StaffNames = new string[6] {
		"Wooden Staff",
		"Staff of Curiosities",
		"Supreme Magic Rod",
		"Oakwood Staff",
		"Magic Stick",
		"Pretty Cool Rod"
	};

	void Start (){
		CreateWeapon ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString ());
		Debug.Log (newWeapon.Strength.ToString());
		Debug.Log (newWeapon.Mana.ToString());
	}

	public void CreateWeapon(){

		newWeapon = new WeaponItems ();
		//create description
		newWeapon.ItemDescription = "Temporary Description.";
		//weapon ID
		newWeapon.ItemID = Random.Range (1, 101);
		//stats
		newWeapon.Strength = Random.Range (1, 10);
		newWeapon.Mana = Random.Range (1, 5);
		//weapon type
		ChooseWeaponType ();
		//spell effect ID
		newWeapon.SpellEffectID = Random.Range (1, 101);
	}

	private void ChooseWeaponType(){
		int randomTemp = Random.Range (0, 2);
		switch (randomTemp) {
		case 0:
			newWeapon.WeaponType = WeaponItems.WeaponTypes.SWORD;
			newWeapon.ItemName = SwordNames [Random.Range (0, 4)];
			break;
		case 1:
			newWeapon.WeaponType = WeaponItems.WeaponTypes.STAFF;
			newWeapon.ItemName = StaffNames [Random.Range (0, 6)];
			break;
		default:
			break;
		}
	}
}
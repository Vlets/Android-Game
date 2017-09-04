using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseItem{
	
	private string itemName;
	private string itemDescription;
	private int itemID;
	public enum ItemTypes{
		WEAPON,
		POTION
	}
	private ItemTypes itemType;

	public BaseItem(){}﻿

	public BaseItem(Dictionary<string, string> itemsDictionary){
		itemName = itemsDictionary["ItemName"];
		itemID = int.Parse (itemsDictionary ["ItemID"]);
		itemType = (ItemTypes)System.Enum.Parse (typeof(BaseItem.ItemTypes), itemsDictionary ["ItemType"].ToString ());
	}﻿

	public string ItemName{
		get{return itemName;}
		set{itemName = value;}
	}
	public string ItemDescription{
		get{return itemDescription;}
		set{itemDescription = value;}
	}
	public int ItemID{
		get{return itemID;}
		set{itemID = value;}
	}
	public ItemTypes ItemType{
		get{return itemType;}
		set{itemType = value;}
	}
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Continue : MonoBehaviour {
	

	public void ContinueGame(){
		GameInformation.spawnPoint=1;
		AutoFade.LoadLevel(GameInformation.currentScene ,1,1,Color.black);
	}
}

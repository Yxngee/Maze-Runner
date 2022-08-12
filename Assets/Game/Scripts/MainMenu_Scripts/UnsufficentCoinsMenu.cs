using UnityEngine;
using System.Collections;

public class UnsufficentCoinsMenu : MonoBehaviour {

	public GameObject UnsufficentMenu;
	public GameObject storeMenu;
	void Start () {
	
	}
	void  Update (){

	}



	public void OnButtonClick(string ButtonName){
		switch (ButtonName){
		case "Ok":
			UnsufficentMenu.SetActive (false);
			SoundController.Static.playSoundFromName ("Click");
			storeMenu.gameObject.SetActive (true);
			break;
		}
	}
}

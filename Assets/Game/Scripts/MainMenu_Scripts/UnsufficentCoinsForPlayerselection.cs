using UnityEngine;
using System.Collections;

public class UnsufficentCoinsForPlayerselection : MonoBehaviour {

	public GameObject UnsufficentCoinsForPlayerselectionMenu;
	public GameObject mainMenu;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnButtonClick(string ButtonName){
		switch (ButtonName){
		case "ok":
			SoundController.Static.playSoundFromName ("Click");
			UnsufficentCoinsForPlayerselectionMenu.SetActive (false);
			mainMenu.gameObject.SetActive (true);
			break;
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;


//using GoogleMobileAds;
//using GoogleMobileAds.Api;
using System;


public class MainMenu : MonoBehaviour {


	//private RewardBasedVideoAd rewardBasedVideo;
	//public string rewardedAdID;
	public Text ResultText;
	bool AdhasShown;

	public GameObject MainMenuParent,CreditsMenuParent,StoreMunuParent,PlayerSelectionmenuParent,missionsParent,exitParent,totalCoinsParent,exitButton;
	// Use this for initialization

	void OnEnable()
	{
		#if UNITY_IOS
		
		ExitButton.SetActive (false);
		#endif
		}

	void Start () {

		//PlayerPrefs.DeleteAll ();


		Time.timeScale = 1;
		//GoogleMobileAdsScript.Instance.RequestInterstitial ();


		AdhasShown = false;
		//rewardBasedVideo = RewardBasedVideoAd.Instance;
		ResultText.gameObject.SetActive (false);
		//RequestRewardBasedVideo ();
		//rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//is,and,on
	public void OnButtunClick(string ButtonName){
		switch(ButtonName){
		case "Play":

			//if (Advertisement.IsReady()) {
			//	Advertisement.Show ();
			//} else {
			//	GoogleMobileAdsScript.Instance.ShowInterstitial ();
			//	GoogleMobileAdsScript.Instance.RequestInterstitial ();
			//}

			SoundController.Static.playSoundFromName("Click");
			MainMenuParent.SetActive(false);
			PlayerSelectionmenuParent.SetActive(true);
			MainMenuScreens.currentScreen=MainMenuScreens.MenuScreens.playerSelectionMenu;
			break;

//		case "More":
//			Application.OpenURL ("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#if UNITY_IPHONE
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			# elif UNITY_ANDROID
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#elif UNITY_WP8
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#endif
//			SoundController.Static.playSoundFromName("Click");
//			break;
//		case "Review":
//			Application.OpenURL ("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#if UNITY_IPHONE
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			# elif UNITY_ANDROID
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#elif UNITY_WP8
//			Application.OpenURL("https://play.google.com/store/apps/developer?id=Ace+Games");
//			#endif
//			SoundController.Static.playSoundFromName("Click");
//			break;

		case "Credits":
			SoundController.Static.playSoundFromName("Click");
			MainMenuParent.SetActive(false);
			CreditsMenuParent.SetActive(true);
			MainMenuScreens.currentScreen=MainMenuScreens.MenuScreens.CredtsMenu;
			break;
		case "Exit":
			SoundController.Static.playSoundFromName("Click");
			exitParent.SetActive(true);
			MainMenuParent.SetActive(false);
			totalCoinsParent.SetActive(false);
			//Application.Quit();
			break;
		case "Store":

			//if (Advertisement.IsReady()) {
			//	Advertisement.Show ();
			//	} else {
			//GoogleMobileAdsScript.Instance.ShowInterstitial ();
			//GoogleMobileAdsScript.Instance.RequestInterstitial ();
			//	}

			PlayerSelectionmenuParent.SetActive(false);
			StoreMunuParent.SetActive(true);
			MainMenuParent.SetActive(false);
			SoundController.Static.playSoundFromName("Click");
			MainMenuScreens.currentScreen=MainMenuScreens.MenuScreens.StoreMenu;
			break;
		case "Missions":
			missionsParent.SetActive(true);
			MainMenuParent.SetActive(false);
			SoundController.Static.playSoundFromName("Click");
			MainMenuScreens.currentScreen=MainMenuScreens.MenuScreens.StoreMenu;
			break;



		}

	}










	//For rewarderd video

	//public void RequestRewardBasedVideo()
	//{
	//	#if UNITY_EDITOR
	//	string adUnitId = "unused";
	//	#elif UNITY_ANDROID
	//	string adUnitId = rewardedAdID;
	//	#elif UNITY_IPHONE
	//	string adUnitId = "ca-app-pub-3940256099942544/1712485313";
	//	#else
	//	string adUnitId = "unexpected_platform";
	//	#endif

	//	rewardBasedVideo.LoadAd(new AdRequest.Builder().Build(), adUnitId);
	//	}


		//call this func from tool
		public void ShowRewardedVideoAds()
		{

		print ("inside");

		//if (rewardBasedVideo.IsLoaded ())
		//{ 
		//rewardBasedVideo.Show ();
		//RequestRewardBasedVideo ();

		//} else{
		//if (Advertisement.IsReady ("rewardedVideo")) {
		//var options = new ShowOptions { resultCallback = HandleShowResult };
		//Advertisement.Show ("rewardedVideo", options);
		//} else {
		//ResultText.gameObject.SetActive (true);
		//ResultText.text = "Sorry,the ad is not available";
		//Invoke ("Setoff", 2f);
		//}
		//}
		}





		//private void HandleShowResult(ShowResult result){
		//switch (result)
		//{
		//case ShowResult.Finished:
		//GiveReward ();
		//ResultText.gameObject.SetActive (true);
		////
		//// YOUR CODE TO REWARD THE GAMER
		//// Give coins etc.
		//break;
		//case ShowResult.Skipped:
		//break;
		//case ShowResult.Failed:
		//break;
		//}
		//}

		private void GiveReward(){
		ResultText.text = "Great, you have been rewarded 500 coins";
		Invoke ("Setoff", 2f);
		PlayerPrefs.SetInt ("TotalCoins", PlayerPrefs.GetInt ("TotalCoins", 0) + 500); 
		//reward here


		}



		// this ad is for admob rewarded
		//public void HandleRewardBasedVideoRewarded(object sender, Reward args)
		//{
		//string type = args.Type;
		//double amount = args.Amount;
		//ResultText.gameObject.SetActive (true);
		//ResultText.text = "Great, you have been rewarded with 500 coins";
		//Invoke ("Setoff", 2f);
		//PlayerPrefs.SetInt ("TotalCoins", PlayerPrefs.GetInt ("TotalCoins", 0) + 500); 
		////reward here

		//}


		void Setoff()
		{
		ResultText.gameObject.SetActive (false);
		AdhasShown = false;
		}



}

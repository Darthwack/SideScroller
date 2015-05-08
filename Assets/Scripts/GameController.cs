using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController controll;
	private Text scoreText;
	public PlayerScript playerScript;
	public GoogleAnalyticsV3 googleAnalytics;
	public float score;
	public long scoreToSubmit;
	public string currentLevel;

	public string headSprite;

	// Use this for initialization
	void Awake () 
	{
		if(controll == null)
		{
			DontDestroyOnLoad(gameObject);
			controll = this;
		} else if (controll != this)
		{
			Destroy(gameObject);
		}
		//currentLevel = Application.loadedLevelName;
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		//playerScript = GetComponent<PlayerScript>();
		string head = PlayerPrefs.GetString("head");
		if(head != null){
			setHead(head);
		}
	}
	
	// Update is called once per frame
	void Update () {
		currentLevel = Application.loadedLevelName;
		//speed -= .001f;
		//Debug.Log(score);
		float currentTime = Mathf.Round(Time.timeSinceLevelLoad);
		if(currentLevel == "Main")
		{
			score = (ObstacleCheck.coinsCollected * 5) + currentTime;
		}
		if(currentLevel == "Main" || currentLevel == "ScoreScreen")
		{
			scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
			scoreText.text = "Score: " + score;
		}



		

	}

	public void setHead(string headName)
	{
		headSprite = headName;
		//Debug.Log(headSprite);
	}
	public string getHead()
	{
		return headSprite;
	}



	public void LogEvent()
	{
		Debug.Log ("Log: " + System.Convert.ToInt64(score));
		//googleAnalytics.LogEvent("Main", "Died", "Score", System.Convert.ToInt64(score));
	}


}

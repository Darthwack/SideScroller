using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private Text scoreText;
	public PlayerScript playerScript;

	// Use this for initialization
	void Start () 
	{
		playerScript = GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		scoreText.text = "Score: " + PlayerScript.distanceTraveled;

	}


}

using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class PlayerInput : MonoBehaviour {

	public PlayerScript player;

	// Use this for initialization
	void Start () {
		player = GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	
	void OnFlick(FlickGesture gesture)
	{
		Debug.Log("Jump");
		if(gesture.ScreenFlickVector.y >= 50)
		{
			player.Jump();
		}
	}
}

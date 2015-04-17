using UnityEngine;
using System.Collections;

public class ObstacleCheck : MonoBehaviour {

	public PlayerScript playerScript;
	public static int coinsCollected;

	// Use this for initialization
	void Start () {
		coinsCollected = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Rock(Clone)")
		{
			Debug.Log("Rock");
			Application.LoadLevel("ScoreScreen");
		} 
		if (other.name == "Tree(Clone)" && !playerScript.isSliding)
		{		
			Debug.Log("Tree");
			Application.LoadLevel("ScoreScreen");
		}
		
		
		if(other.tag == "Coin")
		{
			Debug.Log("hi");
			Destroy(other.gameObject);
			coinsCollected++;
		}
	}

}

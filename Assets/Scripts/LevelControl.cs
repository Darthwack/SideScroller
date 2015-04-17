using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {

	
	public static float speed;
	public GameObject player;

	// Use this for initialization
	void Start () {

			speed = -1;
			Instantiate(player, new Vector3(-3.5f, -2.7f, 0), Quaternion.identity);
			ObstacleCheck.coinsCollected = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

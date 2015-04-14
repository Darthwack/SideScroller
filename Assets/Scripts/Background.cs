using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player1")
		{
			Invoke("DestroySelf", 10);
		}
	}

	void DestroySelf()
	{
		Destroy(gameObject);
	}
}

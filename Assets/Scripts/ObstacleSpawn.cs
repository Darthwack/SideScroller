using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour {

	public GameObject tree;
	public GameObject rock;
	public GameObject coinArray1;
	public GameObject coinArray2;
	/// <summary>
	/// Scrolling speed
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	/// <summary>
	/// Movement should be applied to camera
	/// </summary>
	public bool isLinkedToCamera = false;
	
	/// <summary>
	/// 1 - Background is infinite
	/// </summary>
	public bool isLooping = false;
	
	/// <summary>
	/// 2 - List of children with a renderer.
	/// </summary>
	//private  backgroundPart;

	public float timeToSpawn;
	public float currentTime;

	// Use this for initialization
	void Start () {
		timeToSpawn = 5.0f;
		StartCoroutine(Example());
	}
	
	// Update is called once per frame
	void Update () 
	{

		currentTime = Time.timeSinceLevelLoad;
		Vector3 movement = new Vector3(
			speed.x * direction.x,
			speed.y * direction.y,
			0);
		
		movement *= Time.deltaTime;
		transform.Translate(movement);
	}

	IEnumerator Example() {
		//timeToSpawn = currentTime + 5;
		//print(Time.time);
		int thingToSpawn = Random.Range(0,3);
		switch(thingToSpawn)
		{
			case 0:
				GameObject newTree = Instantiate(tree, new Vector3(7, -2.32f, 0), Quaternion.identity) as GameObject;
				newTree.transform.parent = gameObject.transform;
				break;
			case 1:
				GameObject newRock = Instantiate(rock, new Vector3(7, -3.3f, 0), Quaternion.identity) as GameObject;
				newRock.transform.parent = gameObject.transform;
				break;
			case 2:
				GameObject newCoin1 = Instantiate(coinArray1, new Vector3(7, -2.5f, 0), Quaternion.identity) as GameObject;
				newCoin1.transform.parent = gameObject.transform;
				break;
			case 3:
				GameObject newCoin2 = Instantiate(coinArray2, new Vector3(7, -2.5f, 0), Quaternion.identity) as GameObject;
				newCoin2.transform.parent = gameObject.transform;
				break;
			default:
				break;
		}



		timeToSpawn -= 0.05f;
		//print(Time.time);
		yield return new WaitForSeconds(timeToSpawn);
		StartCoroutine(Example());
	}

//	IEnumerator SpawnObject()
//	{
//		//yield return WaitForSeconds(5);
//
//	}
}

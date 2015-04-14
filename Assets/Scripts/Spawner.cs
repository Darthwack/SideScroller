using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Collider2D playerCollider;
	public GameObject bg;
	public Collider2D bgCollider;
	public Transform bgPos;
	public Transform newPos;
	public GameObject tree;
	public GameObject rock;
	public static int k;
	public GameObject[] bgList;

	// Use this for initialization
	void Start () {
		//playerTrans = GetComponent<Transform>();
		//backGround = GetComponent<GameObject>();
		k = 0;
		bgList = new GameObject[10];
		AppendBG();
		AppendBG();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(k);
		//Debug.Log(bgList.Length);
	}

	public void AppendBG()
	{
		//bgList = new GameObject[i];
		//bgList[i] = bg.gameObject;
		newPos.transform.position = new Vector3(10f * k, 0, 0);
		bg.name = "Background" + k;
		Instantiate(bg, newPos.transform.position, Quaternion.identity);
		AppendObstacles();
		//Debug.Log(i);
		k++;
	}

	void AppendObstacles()
	{
		GameObject newRock = Instantiate(rock, new Vector3((newPos.transform.position.x + Random.Range(0, 10)), -2.05f, 0), Quaternion.identity) as GameObject;
		newRock.transform.parent = GameObject.Find("Background" + k + "(Clone)").transform;
		GameObject newTree = Instantiate(tree, new Vector3((newPos.transform.position.x + Random.Range(0, 10)), -2f, 0), Quaternion.identity) as GameObject;
		newTree.transform.parent = GameObject.Find("Background" + k + "(Clone)").transform;
	}

}

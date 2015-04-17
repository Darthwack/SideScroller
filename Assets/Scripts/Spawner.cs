using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Collider2D playerCollider;
	public Transform camera;
	public GameObject bg;
	public GameObject ground;
	public Collider2D bgCollider;
	public Transform bgPos;
	public Transform newPos;
	public Transform newGroundPos;
	public GameObject tree;
	public GameObject rock;
	public static int k;
	public static int l;
	public GameObject[] bgList;
	public GameObject player;
	//public Renderer rend;

	// Use this for initialization
	void Start () {
		//rend = GetComponent<Renderer>();
		//playerTrans = GetComponent<Transform>();
		//backGround = GetComponent<GameObject>();
		k = 0;
		l = 0;
		AppendBGStart();
		AppendBGStart();
		AppendBGStart();
		Instantiate(player, new Vector3(-2.16f, -2.22f, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		//camera.transform.position.y = 0;
		//Debug.Log(k);
		//Debug.Log(bgList.Length);
	}

	public void AppendBGStart()
	{
		//bgList = new GameObject[i];
		//bgList[i] = bg.gameObject;
		//Vector3 size = rend.bounds.size;
		newPos.transform.position = new Vector3(9f * k, 0, 0);
		newGroundPos.transform.position = new Vector3(8.9f * l, -2.81f, 0);
		bg.name = "Background" + k;
		ground.name = "Ground" + l;
		Instantiate(bg, newPos.transform.position, Quaternion.identity);
		Instantiate(ground, newGroundPos.transform.position, Quaternion.identity);
		AppendObstacles();
		//Debug.Log(i);
		l++;
		k++;
		//yield return new WaitForSeconds(0.2f);
	}
	
	public void AppendBG()
	{
		//bgList = new GameObject[i];
		//bgList[i] = bg.gameObject;
		//Vector3 size = rend.bounds.size;
		newPos.transform.position = new Vector3(8.96f * 3, 0, 0);
		bg.name = "Background" + k;
		Instantiate(bg, newPos.transform.position, Quaternion.identity);
		k++;
		//AppendObstacles();
		//Debug.Log(i);
		//yield return new WaitForSeconds(0.2f);
	}
	public void AppendGround()
	{
		//bgList = new GameObject[i];
		//bgList[i] = bg.gameObject;
		//Vector3 size = rend.bounds.size;
		newGroundPos.transform.position = new Vector3(8.9f * 3, -2.81f, 0);
		ground.name = "Ground" + l;
		Instantiate(ground, newGroundPos.transform.position, Quaternion.identity);
		AppendObstacles();
		//Debug.Log(i);
		l++;
		//yield return new WaitForSeconds(0.2f);
	}

	void AppendObstacles()
	{
//		GameObject newRock = Instantiate(rock, new Vector3((newPos.transform.position.x + Random.Range(0, 6)), -1.25f, 0), Quaternion.identity) as GameObject;
//		newRock.transform.parent = GameObject.Find("Background" + k + "(Clone)").transform;
//		GameObject newTree = Instantiate(tree, new Vector3((newPos.transform.position.x + Random.Range(0, 6)), -.3f, 0), Quaternion.identity) as GameObject;
//		newTree.transform.parent = GameObject.Find("Background" + k + "(Clone)").transform;
	}

}

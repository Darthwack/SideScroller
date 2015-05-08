using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeadChange : MonoBehaviour {

	Button head;
	string headText;


	// Use this for initialization
	void Start () 
	{
		head = gameObject.GetComponent<Button>();
	}
	
	// Update is called once per frame
	void OnGUI() 
	{
		head.onClick.AddListener(setHead);
	}

	void setHead() 
	{
		headText = head.GetComponentInChildren<Text>().text;
		GameController.controll.setHead(headText);
		PlayerPrefs.SetString("head",headText);
	}
}

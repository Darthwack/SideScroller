﻿using UnityEngine;
using System.Collections;

public class ChangeHead : MonoBehaviour {

	 Sprite head;

	public string headName;
	//SpriteRenderer rend;

   void	Awake()
	{
		headName = GameController.controll.getHead();
		head = Resources.Load<Sprite>(headName) as Sprite;
		GetComponent<SpriteRenderer>().sprite = head;

	}


   
}
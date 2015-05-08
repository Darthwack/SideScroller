using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TogglePanel : MonoBehaviour {
	
	// Use this for initialization

	
	// Update is called once per frame

	public void ToggleFaces(){
		GameController.controll.togglePanel();
	}

}

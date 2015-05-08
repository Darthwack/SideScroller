using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	
	public void ChangeSceneTo (int sceneIndex) {
		if (sceneIndex == 0){
		GameController.controll.panel.SetActive(true);
		}
		Application.LoadLevel (sceneIndex);

	
	}
}

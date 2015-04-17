using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	
	public void ChangeSceneTo (int sceneIndex) {
		Application.LoadLevel (sceneIndex);
	
	}
}

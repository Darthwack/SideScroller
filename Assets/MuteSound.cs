using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteSound : MonoBehaviour {

	public Toggle toggle;



	// Use this for initialization
	void Start () 
	{
		toggle = GameObject.Find("Mute").GetComponent<UnityEngine.UI.Toggle>();
		toggle.isOn = SoundManager.instance.mute;
		toggle.onValueChanged.AddListener(switchMute);
	}

//	void OnGUI(){
//
//		if (toggle.isOn){ //refrence not set to an instance of an object???
//			AudioListener.pause = true;
//		}else{
//			AudioListener.pause = false;
//		}
//		}

	void switchMute(bool bl){
		SoundManager.instance.muteSound(bl);
	}
//	
//	// Update is called once per frame
////	void muteMe(){
////		if (toggle.isOn){
////			AudioListener.pause = true;
////		}else{
////			AudioListener.pause = false;
////		}
////	}
}

using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
	  bool paused = false;

	public void pauseGame()
	{

		paused = isPaused (paused);


	}
	public bool isPaused(bool paused)
	{
		if(paused)
		{
			Time.timeScale = 1f;
			Debug.Log (paused);
			paused = false;
			return paused;
		}
		else
		{
			Time.timeScale = 0f;
			Debug.Log (paused);
			paused = true;
			return paused;
			
			
			
		}
	}

}

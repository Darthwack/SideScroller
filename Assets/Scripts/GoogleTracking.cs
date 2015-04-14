using UnityEngine;
using System.Collections;

public class GoogleTracking : MonoBehaviour {

	public GoogleAnalyticsV3 googleAnalytics;

	// Use this for initialization
	void Start () {
		googleAnalytics.LogScreen("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Cloud.Analytics;

public class UnityAnalyticsIntegration : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		const string projectId = "f5a8e75b-fd05-4383-b376-7507220c359f";
		UnityAnalytics.StartSDK (projectId);
		
	}
	
}
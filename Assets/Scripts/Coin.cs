using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void Update()
	{
		//transform.rotation = Quaternion.AngleAxis(30, Vector3.up);
		
		var rot = transform.rotation;
		
		transform.rotation = rot * Quaternion.Euler(0, 90 * Time.deltaTime, 0); // this is 90 degrees around y axis
		
		if (transform.up != Vector3.up) {
			
			//transform.LookAt(transform.position + transform.forward, Vector3.up);
			
			//transform.Rotate(Vector3.up * Time.deltaTime *20, Space.World);
			
		}
		
	}

}

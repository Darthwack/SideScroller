using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public Animator anim;
	public PlayerScript playerScript;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Rotated()
	{
		playerScript.isSliding = false;
		anim.SetBool("CanRotate", false);
	}
}

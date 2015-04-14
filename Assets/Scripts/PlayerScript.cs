using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class PlayerScript : MonoBehaviour {

	public GameObject player;
	public BoxCollider2D groundCheck;
	public float speed;
	public Vector2 force;
	public Rigidbody2D rb;
	public Animator animator;
	public AudioClip jumpClip;


	private float startPos;
	private float currentPos;

	public static float distanceTraveled;

	private bool grounded;
	//private bool spaceDown;

	public Spawner spawner;

	// Use this for initialization
	void Start () {
		grounded = true;
		player = GetComponent<GameObject>();
		rb = GetComponent<Rigidbody2D>();
		//spawner = GetComponent<Spawner>();
		speed = 2.5f;
		startPos = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(speed * Time.deltaTime, 0f, 0f);

//		if(Input.GetKeyDown("space"))
//		{
//			spaceDown = true;
//		}
//		else if (Input.GetKeyUp("space"))
//		{
//			spaceDown = false;
//		}
//
//		if(spaceDown && grounded) {
//			rb.AddForce(transform.up * 20f);
//		}
		currentPos = this.transform.position.x;

		distanceTraveled = currentPos - startPos;

	}

	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log(Spawner.k);
		if(other.name == "Background" + (Spawner.k - 2) + "(Clone)")
		{
			spawner.AppendBG();
		}
	}

	public void Jump()
	{
		rb.velocity = new Vector3(0, 5, 0);
		animator.SetTrigger ("PlayerJump");
		SoundManager.instance.RandomizeSfx (jumpClip);
	}

	void OnFlick(FlickGesture gesture)
	{
		Debug.Log("Jump");
		if(gesture.ScreenFlickVector.y >= 50 && grounded)
		{
			grounded = false;
			Jump();
		}
	}

}

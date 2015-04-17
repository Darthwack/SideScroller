using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class PlayerScript : MonoBehaviour {

	public GameObject player;
	public GameObject playerSprite;
	public BoxCollider2D groundCheck;
	public float speed;
	public Vector2 force;
	public Rigidbody2D rb;
	public Sprite sprite;
	public bool isSliding;
	public Animator anim;

	private float startPos;
	private float currentPos;
	public static float distanceTraveled;
	public static int coinsCollected;
	private bool grounded;
	//private bool spaceDown;

	public Spawner spawner;
	public AudioClip rockSlide;
	public AudioClip jump;

	// Use this for initialization
	void Start () {
		grounded = true;
		player = GetComponent<GameObject>();
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		//spawner = GetComponent<Spawner>();
		//speed = 2.5f;
		startPos = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Invoke("AddDist", 1);
		//Debug.Log(distanceTraveled);
		//speed += (.01f * Time.deltaTime);
		//Debug.Log(speed);
		//transform.Translate(speed * Time.deltaTime, 0f, 0f);
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


	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Ground" + (Spawner.l - 3) + "(Clone)")
		{
			spawner.AppendGround();
		}

		if(other.name == "Background" + (Spawner.k - 3) + "(Clone)")
		{
			spawner.AppendBG();
		}

		if(other.tag == "Ground")
		{
			grounded = true;
			//Debug.Log(grounded);
		}

	}

	public void Jump()
	{
		SoundManager.instance.RandomizeSfx(jump);
		anim.SetTrigger("PlayerJump");
		rb.velocity = new Vector3(0, 5, 0);
		grounded = false;
	}

	void OnFlick(FlickGesture gesture)
	{
		//Debug.Log("Jump");
		if(gesture.ScreenFlickVector.y >= 50 && grounded && !isSliding)
		{
			Jump();
		} else if (gesture.ScreenFlickVector.y <= -50)
		{
			SoundManager.instance.RandomizeSfx(rockSlide);
			//canRotate = true;
			anim.SetTrigger("PlayerSlide");
		}
	}

	void IsSliding()
	{
		if(!isSliding){
			isSliding = true;
		} else 
		{
			isSliding = false;
		}
	}


//	IEnumerator AddDist()
//	{
//		Debug.Log(distanceTraveled);
//		distanceTraveled += 1;
//		yield return new WaitForSeconds(1);
//	}

}

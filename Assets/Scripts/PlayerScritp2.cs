using UnityEngine;
using System.Collections;

public class PlayerScritp2 : MonoBehaviour {

	public GameObject player;
	public float speed;
	public Vector2 force;
	public Rigidbody2D rb;
	
	private float startPos;
	private float currentPos;
	public static float distanceTraveled;

	
	public AudioClip music;
	public float[] soundLevel;

	private float pos;
	private bool grounded;
	private bool spaceDown;
	
	// Use this for initialization
	void Start () {
		grounded = true;
		player = GetComponent<GameObject>();
		rb = GetComponent<Rigidbody2D>();
		speed = 2.5f;
		startPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		soundLevel = AudioListener.GetSpectrumData(1024, 0, FFTWindow.Hanning);
		Debug.Log(soundLevel[1]);
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
		
		if(Input.GetKeyDown("space"))
		{
			spaceDown = true;
		}
		else if (Input.GetKeyUp("space"))
		{
			spaceDown = false;
		}

		currentPos = transform.position.x;

		transform.position = new Vector3(currentPos, soundLevel[1] * 50, 0);

		/*if(spaceDown && grounded) {
			pos += .1f;
			transform.position = new Vector3(currentPos, pos, 0);
			print(transform.position.x);
			//Invoke("Example()", 0.5f);
		}
		else if (pos >= 0)
		{
			pos -= .1f;
			transform.position = new Vector3(currentPos, pos, 0);
		}*/
		
		distanceTraveled = currentPos - startPos;
		
	}

	void Example() {

	}
}

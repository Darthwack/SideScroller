#pragma strict

var  speed = 0.1;

function Update () {
	var moveDir = new Vector3();
	//get axis will work with both the keyboard
	//and with gamepads. Gets how far an axis is currently pushed in.
	//For keyboards its either 1,0,-1
	//For gamepads its a range between -1 and 1
	moveDir.y = Input.GetAxis("Vertical") * speed;
	moveDir.x = Input.GetAxis("Horizontal") * speed;
	this.transform.Translate( moveDir );
}
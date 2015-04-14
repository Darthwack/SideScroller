#pragma strict

var moveDirection = Vector2(0.1, 0);
var lifespan = 2.0;

function Start () {
	//destroy removes an object from the game
	//the second argument - seconds to wait before destructions
	Destroy(this.gameObject, lifespan);
}

function Update () {
	//move in the direction set in 'moveDirection'
	
	var curPosition = this.transform.position;
	curPosition += moveDirection;
	this.transform.position = curPosition;
}
#pragma strict

var moveDirection = Vector2(-0.1, 0);

function Update () {
	var curPosition = this.transform.position;
	curPosition += moveDirection;
	this.transform.position = curPosition;
}
#pragma strict

var hurtTag = "Bullet";

//whenever the enemy enters a trigger
function OnTriggerEnter2D( other :Collider2D ) {
	//did we collide with something we actually care about?
	if( other.gameObject.tag == hurtTag ) {
		Destroy(other.gameObject);
		Destroy(this.gameObject);
	}
}

function Update () {

}
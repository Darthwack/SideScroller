#pragma strict

//what we'll be shooting
var bullet:GameObject;

//where we'll be shooting from
var spawnLocation : Transform;

//so we can't fire a bajillion shots a second
//the higher the number, the slower the player shoots
var shotDelay = 30;

//
var _shotTimer = 0;

function Update () {

	if(_shotTimer < 0) {
		//we can shoot!
		//I suppose that means its a good day, or something
		
		//if the left mouse button is down
		if( Input.GetButton("Jump") ) {
			//create a new bullet, position it where our spawn point is
			Instantiate( bullet, spawnLocation.position, spawnLocation.rotation);
			
			//reset the timer
			_shotTimer = shotDelay;
		}
		
	} else {
		//keep decrementing shot timer until we can shoot again
		_shotTimer --;
	}

}
#pragma strict



function Update () {

	//where the mouse is on the screen (2D, xy location)
	var mousePos = Input.mousePosition;
	
	//where the mouse is positioned in the 'world'
	//the z of '10' is so its far enough back the camera can see it.
	var wantedPos = Camera.main.ScreenToWorldPoint( 
							Vector3(mousePos.x, mousePos.y, 10 ) 
					);
	
	//calculates a new a position for the attached game object
	//that is "10%" closer to where the mouse is pointing
	wantedPos = Vector3.Lerp(this.transform.position, wantedPos, .1);
	
	//update this game object's position
	this.transform.position = wantedPos;
	
}
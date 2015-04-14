#pragma strict

//an array of different enemies to spawn
var enemyPrefabs:GameObject[];

function Update () {
	
	if(Random.Range(0, 100) < 1) {
		
		//choose a random enemy prefab to spawn
		var chosenEnemy:GameObject = 
			enemyPrefabs[ Random.Range(0, enemyPrefabs.length) ];
			
		//find a random y-position (off screen) to spawn it at
		var spawnLocation:Vector2 = 
			new Vector2( 10.0, Random.Range(-2.0, 4.0));
		
		//make a new enemy on the screen
		var createdEnemy:GameObject = 
			Instantiate( chosenEnemy, 
							spawnLocation, 
							Quaternion.identity);
	
		//make the new enemy a child of the enemies layer
		createdEnemy.transform.parent = this.transform;
	}
}
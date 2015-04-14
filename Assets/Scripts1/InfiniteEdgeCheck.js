#pragma strict
/*
public var rootBG:Transform;
//private var bgList:List.<Transform>;
private var bgList:Array;

function Awake()
{

	bgList = new Array();
	
	//bgList = new List.<Transform>();

	//get all BGs from the parent BG and put those on the list
	for (var i = 0; i < rootBG.childCount; i++)
	{
	    bgList.Add(rootBG.GetChild(i).gameObject);
	}

	bgList.sort(ComparePosition);

}

function ComparePosition(obj1:GameObject, obj2:GameObject) {
	return obj1.transform.position.x - obj2.transform.position.x;
}

function Update() {
	for(var i = 0; i < bgList.length; i++) {
	
		var curBGElm:GameObject = (bgList[i] as GameObject);
		var curPos = curBGElm.transform.position;
	
		if(curPos.x + curBGElm.renderer.bounds.size.x < this.transform.position.x) {
			var lastBG:GameObject = (bgList[bgList.length-1] as GameObject);
			
			var lastPosition:Vector3 = lastBG.transform.position;
            var lastSize:Vector3 = (lastBG.renderer.bounds.max - lastBG.renderer.bounds.min);
			
			curPos.x = lastPosition.x + lastSize.x;
			//curPos.x = lastBG.transform.position.x + lastBG.renderer.bounds.size.x;
			//curPos.x = lastBG.renderer.bounds.max.x;
			curBGElm.transform.position = curPos;
			bgList.push( bgList.shift() );
		}
	}
}

function OnTriggerExit2D(c:Collider2D)
{
/*
	var curPos = c.gameObject.transform.position;
	
	Debug.Log( (this.collider2D as BoxCollider2D).size );
	
	curPos.x = (this.collider2D as BoxCollider2D).size.x + this.transform.position.x;
	c.gameObject.transform.position = curPos;
	

*/
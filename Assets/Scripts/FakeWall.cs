using UnityEngine;
using System.Collections;

public class FakeWall : MonoBehaviour {

	public BoxCollider theFakeWall;

	// Use this for initialization
	void Start () 
	{	
		//at start of game, the wall is passable
		theFakeWall.isTrigger = true;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	//once ball passes through
	void OnTriggerExit(Collider theBall)
	{
		if(theBall.transform.tag == "TheBall")
		{
			theFakeWall.isTrigger = false;
		}
	}


}//FakeWall Class

using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour 
{
	//respawn
	//score
	//fakeWall trigger

	public FakeWall fakeWall;
	public TheBall thePinball;


	//this is only called when the ball enters the kill box
	//what it does is makes fakeWall be fake again
	public void Respawn()
	{
		fakeWall.theFakeWall.isTrigger = true;
		/*
		//reset the momentum of the ball
		thePinball.pinball.velocity = new Vector3(0f,0f,0f); 
		
		//to keep the ball from spinning, i freeze it
		thePinball.pinball.freezeRotation = true;
		thePinball.pinball.transform.position = thePinball.startingPosition;	//reset the position to its starting point
		*/
	}



}//GameMaster Class

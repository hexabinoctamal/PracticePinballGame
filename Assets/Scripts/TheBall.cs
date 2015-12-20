using UnityEngine;
using System.Collections;

public class TheBall : MonoBehaviour {

	

	//because i can't control the y-axiz, i can't have the ball go up/down any kind of elevation
	//the level design will have to be fairly 2D based even though it is made 3D 
	public Vector3 startingPosition;
	public Rigidbody pinball;
	public GameMaster gameMaster;

	// Use this for initialization
	void Awake () 
	{
		pinball = GetComponent<Rigidbody>();
		startingPosition = this.transform.position;

		//the ball keeps spinning for some reason so this gets rid of it from the getgo
		pinball.freezeRotation = true; 
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

	}
	

	void OnTriggerEnter(Collider obj)
	{
		if(obj.transform.tag == "DeathBox")
		{
			StartCoroutine(WaitToRespawn());
			gameMaster.Respawn();
		}
		if(obj.transform.tag == "FakeWall"){}

		//once it leaves the fakewall/respawns(upon leaving fakewall), it will continue 
		//acting like a normal ball properly
		pinball.freezeRotation = false;
	}//OnTriggerEnter


	IEnumerator WaitToRespawn()
	{
		yield return new WaitForSeconds(1);
		//reset the momentum of the ball
		pinball.velocity = new Vector3(0f,0f,0f); 
		
		//to keep the ball from spinning, i freeze it
		pinball.freezeRotation = true;
		pinball.transform.position = startingPosition;	//reset the position to its starting point

	}


}//TheBall Class

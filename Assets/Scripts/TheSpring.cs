using UnityEngine;
using System.Collections;

public class TheSpring : MonoBehaviour {

	private Vector3 startingPosition;
	public Rigidbody fakeSpring;
	public TheBall ballRef;

	private bool ballOnSpring;

	// Use this for initialization
	void Awake () {
		ballOnSpring = false;
		startingPosition = transform.position;
		fakeSpring = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Transform>().position = startingPosition;
		if(Input.GetKey(KeyCode.Space))
		{
			GetComponent<Transform>().position -= new Vector3(0f,0f,-0.2f);

			if(ballOnSpring)
			{
				ballRef.pinball.AddForce(transform.forward * 1000);
			}//if

			//once ball leaves the spring, we can no longer hit it...unless it comes back
			ballOnSpring = false;
		}//if

	}//FixedUpdate()


	void OnCollisionEnter(Collision theObj)
	{

		if(theObj.gameObject.tag == "TheBall")
		{
			ballOnSpring = true;
		}//if

	}//OnCollisionEnter()


} //TheSpring Class

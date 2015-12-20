using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {

	private float flipperSpring = 100000f; 
	private float flipperDamp = 0f;
	private float maxAngleForFlipper = -45f;
	private float restPositionForFlipper = 0f;


	private HingeJoint theRightFlipper;
	private JointSpring spr;

	// Use this for initialization
	void Start () 
	{

		theRightFlipper = GetComponent<HingeJoint>();
		theRightFlipper.useSpring = true;
		spr = theRightFlipper.spring;
		spr.spring = flipperSpring;
		spr.damper = flipperDamp;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(Input.GetKey(KeyCode.D))
		{

			spr.targetPosition = maxAngleForFlipper;
		}
		else
		{
			spr.targetPosition = restPositionForFlipper;
		}

		theRightFlipper.spring = spr;

	
	}//Update 
	



}//RightFlipper Class

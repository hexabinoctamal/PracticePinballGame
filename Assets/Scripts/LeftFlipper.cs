using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

	private float flipperSpring = 100000f; 
	private float flipperDamp = 1f;
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
	void FixedUpdate () 
	{
		
		if(Input.GetKey(KeyCode.A))
		{
			
			spr.targetPosition = maxAngleForFlipper;
		}
		else
		{
			spr.targetPosition = restPositionForFlipper;
		}
		
		theRightFlipper.spring = spr;
		
		
	}//Update 
	
	
	


}

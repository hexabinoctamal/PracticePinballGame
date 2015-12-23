using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

	private float flipperSpring = 100000f; 
	private float flipperDamp = 1f;
	private float maxAngleForFlipper = -45f;
	private float restPositionForFlipper = 0f;
	
	
	private HingeJoint theLeftFlipper;
	private JointSpring spr;

    bool flipperHasBeenFlipped = false;

	// Use this for initialization
	void Start () 
	{
		
		theLeftFlipper = GetComponent<HingeJoint>();
		theLeftFlipper.useSpring = true;
		spr = theLeftFlipper.spring;
		spr.spring = flipperSpring;
		spr.damper = flipperDamp;
		
	}
	
    // Updated is called 1/60
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            flipperHasBeenFlipped = true;
        }
        else
        {
            flipperHasBeenFlipped = false;
        }
    }

	// Fixed Update is called 1/50
	void FixedUpdate () 
	{

        if(flipperHasBeenFlipped)
        {
            spr.targetPosition = maxAngleForFlipper;
        }
        else
        {
            spr.targetPosition = restPositionForFlipper;
        }
		
		theLeftFlipper.spring = spr;
		
		
	}//FixedUpdate 
	
	
	


}

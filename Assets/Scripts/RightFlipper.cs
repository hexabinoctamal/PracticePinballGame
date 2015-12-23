using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {

	private float flipperSpring = 100000f; 
	private float flipperDamp = 0f;
	private float maxAngleForFlipper = -45f;
	private float restPositionForFlipper = 0f;


	private HingeJoint theRightFlipper;
	private JointSpring spr;

    bool flipperHasBeenFlipped = false;

	// Use this for initialization
	void Start () 
	{

		theRightFlipper = GetComponent<HingeJoint>();
		theRightFlipper.useSpring = true;
		spr = theRightFlipper.spring;
		spr.spring = flipperSpring;
		spr.damper = flipperDamp;

	}

    // Updated is called 1/60
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            flipperHasBeenFlipped = true;
        }
        else
        {
            flipperHasBeenFlipped = false;
        }
    }

    // Fixed Update is called 1/50
    void FixedUpdate()
    {

        if (flipperHasBeenFlipped)
        {
            spr.targetPosition = maxAngleForFlipper;
        }
        else
        {
            spr.targetPosition = restPositionForFlipper;
        }

        theRightFlipper.spring = spr;


    }//FixedUpdate 
	



}//RightFlipper Class

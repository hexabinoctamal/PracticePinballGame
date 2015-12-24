using UnityEngine;
using System.Collections;

public class TheSpring : MonoBehaviour {

	private Vector3 startingPosition;
    [SerializeField] Rigidbody theBall;

	bool ballOnSpring;
    float push = 0;
    float maxPush = 50f;

	// Use this for initialization
	void Awake () 
    {
		ballOnSpring = false;
		startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        /* This works like a normal spring system in pinball games. You will hold space bar
         * up until a certain point in which the longer you hold space bar, the faster the ball will shoot out
         * of the beginning section. At the moment, the spring can exert up to 50 units of force. 
         */ 

        if(Input.GetKey(KeyCode.Space) && ballOnSpring)
        {
            if(push >= maxPush)
            {
                push = maxPush;
            }
            else
            {            
                push += 0.5f; // adds 0.5 unit of force every 1/50 of frame
            }
           
        }
        else if(Input.GetKeyUp(KeyCode.Space) && ballOnSpring)
        {
            Debug.Log(push);
            theBall.AddForce(Vector3.forward * push, ForceMode.Impulse);
            push = 0;
        }
	}//FixedUpdate()


	void OnTriggerEnter(Collider theObj)
	{

		if(theObj.gameObject.CompareTag("TheBall"))
		{
			ballOnSpring = true;
		}//if

	}//OnTriggerEnter()

    void OnTriggerExit(Collider theObj)
    {
        if(theObj.CompareTag("TheBall"))
        {
            ballOnSpring = false;
        }
    }


} //TheSpring Class

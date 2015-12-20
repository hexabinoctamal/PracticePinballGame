﻿using UnityEngine;
using System.Collections;

public class BumperHit : MonoBehaviour {


	public float bumpForce;
	public float forceRadius;
	public GameObject hitParticles; 
	
	void Awake()
	{
		bumpForce = 500f;
		forceRadius = 2f;
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "TheBall")
		{
			col.GetComponent<Rigidbody>().AddForce(col.transform.forward * bumpForce);
		}
		Object temp = Instantiate(hitParticles, this.transform.position, Quaternion.identity);
		Destroy(temp, 1f);
	}
	
	/*
	void OnCollisionEnter()
	{
		foreach(Collider col in Physics.OverlapSphere(transform.position, forceRadius))
		{
			if(col.attachedRigidbody)
			{
				col.attachedRigidbody.AddExplosionForce(bumpForce, transform.position,forceRadius);
			}
		}
		Object temp = Instantiate(hitParticles, this.transform.position, Quaternion.identity);
		Destroy(temp, 1f);
	}
	*/
	/*
	void OnCollisionEnter(Collision theBall)
	{
		float x = 0f;
		float z = 0f;

		if(theBall.transform.tag == "TheBall" && theBall.rigidbody.velocity.magnitude < 15f)
		{

			if(ballRef.pinball.velocity.x > 0)
				x =  bump;
			else if(ballRef.pinball.velocity.x <= 0)
				x =  (-bump);


			if(ballRef.pinball.velocity.z > 0)
				z =  bump;
			else if(ballRef.pinball.velocity.z <= 0)
				z = (-bump);

			Object temp = Instantiate(hitParticles, this.transform.position, Quaternion.identity);
			ballRef.pinball.AddForce(new Vector3(x,0f,z));
			Destroy(temp, 1f);
		}//if

	}//OnCollisionEnter
	*/




}//LeftBumperHit Class


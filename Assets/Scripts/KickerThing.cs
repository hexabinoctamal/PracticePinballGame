using UnityEngine;
using System.Collections;

public class KickerThing : MonoBehaviour {


	public float bumpForce;
	public float forceRadius;
	public GameObject hitParticles;

	void Awake()
	{
		bumpForce = 500f;
		forceRadius = 2f;
	}

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
}

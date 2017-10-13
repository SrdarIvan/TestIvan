using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour 
{

	public float Speed = 5.0f;
	public float DistanceToKeep = 1.0f;

	public Transform Target;

	void Update ()
	{
		/*
		Vector3 direction = Target.position - transform.position;
		direction.Normalize ();

		transform.Translate (direction * Speed * Time.deltaTime);
		*/
		if (Target == null)
			return;

		transform.LookAt (Target);

		float distanceToTarget = Vector3.Distance (transform.position, Target.position);

		if (distanceToTarget > DistanceToKeep) {
			transform.position += transform.forward * Speed * Time.deltaTime;
		}
	}
		public void SetTarget (Transform newTarget)
		{
			Target = newTarget;
		}
}

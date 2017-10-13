using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float Speed = 10.0f;

	private float _moveHorizontal = 0.0f;
	private float _moveVertical = 0.0f;

	private Rigidbody _rigidbody;

	void Start () 
	{
		_rigidbody = GetComponent<Rigidbody> ();
	}
	

	void Update () 
	{
		
		CheckForInput ();
		//transform.Translate (direction * Speed * Time.deltaTime);
	}

	void CheckForInput ()
	{
		_moveHorizontal = Input.GetAxisRaw ("Horizontal");
		_moveVertical = Input.GetAxisRaw ("Vertical");
	}

		void FixedUpdate ()
		{
	    	Move ();
		}

	void Move()
	{
		Vector3 direction = new Vector3 (_moveHorizontal, 0.0f, _moveVertical);
		_rigidbody.AddForce (direction * Speed);
	}
		
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{

	public int Value = 1;

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log ("Coin picked up: " + Value);

			GameManager.gm.AddScore (Value);

			Destroy (gameObject);
		}
	}

}

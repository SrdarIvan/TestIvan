using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour 
{
	public float Damage = 5.0f;
	public GameObject ExplosionPrefab;


	void OnCollisionEnter(Collision other)
	{

		HealthManager healthManager = other.gameObject.GetComponent<HealthManager> ();
	    
		if (healthManager != null) {
			healthManager.ApplyDamage (Damage);
			if (tag != "DeathZone") 
			{
				Instantiate (ExplosionPrefab, transform.position, Quaternion.identity);

				Destroy (gameObject);
			}
		}
	}
		
}

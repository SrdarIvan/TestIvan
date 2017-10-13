using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[System.Serializable]
	public class Extremevalues
	{
		public float MinValue;
		public float MaxValue;

		public float RandomValue ()
		{
			return Random.Range (MinValue, MaxValue);
		}
	}

	public FollowTarget ObjectToSpawn;

	public Extremevalues IntervalValues;

	public bool IsActive = true;

	[SerializeField]
	private GameObject _player;

	void Awake ()
	{
		StartCoroutine (SpawnTimer());
	}

	private void SpawnEnemy ()
	{
		GameObject objectClone = Instantiate (ObjectToSpawn.gameObject, transform.position, Quaternion.identity);
		objectClone.transform.SetParent (transform);

		_player = GameObject.FindWithTag ("Player");
		objectClone.GetComponent<FollowTarget> ().SetTarget (_player.transform);
	}

	private IEnumerator SpawnTimer ()
	{
		while (IsActive)
		{
			yield return new WaitForSeconds (IntervalValues.RandomValue());

			SpawnEnemy ();
		}

	}

}

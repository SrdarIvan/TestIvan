using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour 
{

	public HealthManager Player;
	public Slider HealthSlider;
	public Vector3 UIOffset = Vector3.zero;

	void Update()
	{
		transform.position = Player.transform.position + UIOffset;
		HealthSlider.value = Player.Health;
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour 
{
	public void LoadNewLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}

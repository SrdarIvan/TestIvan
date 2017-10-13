using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager gm;

	public int Score = 0;
	public Text ScoreText;

	public float Timer = 20.0f;
	public Text TimerText;

	public int VictoryScore = 5;
	public Canvas VictoryCanvas;

	void Awake ()
	{
		gm = this;
		VictoryCanvas.enabled = false;
	}

	void Update ()
	{
		ChangeTime (-Time.deltaTime);

	}

	public void PrintName ()
	{
		Debug.Log (gameObject.name);
	}

	public void AddScore (int amount)
	{
		Score += amount;
		ScoreText.text = "Score : " + Score.ToString ();

		if (Score >= VictoryScore) 
		{
			Debug.Log ("Victory!");
			VictoryCanvas.enabled = true;
		}
			
	}

	public void ChangeTime (float amount)
	{
		Timer += amount;
		TimerText.text = "Timer : " + Timer.ToString ();

		if (Timer <= 0.0f) 
		{
			Application.LoadLevel (0);
		}
	}
}

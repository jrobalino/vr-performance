using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	int oldScore;
	public Text text;

	void Update()
	{
		if (GameManager.score != oldScore)
		{
			oldScore = GameManager.score;
			ChangeScoreUI();
		}
	}

	void ChangeScoreUI()
	{
		text.text = "Score: " + GameManager.score.ToString();
	}
}

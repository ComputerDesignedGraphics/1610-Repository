using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro adds library for the UI

public class ScoreManager : MonoBehaviour
{
	public int score; // Keeps score values
	public TextMeshProUGUI scoreText; //Visual text element to be modified

	public void IncreaseScore(int amount) // When called increases score by what amount you set
	{
	
	
	score += amount;
	UpdateScoreText();
	}

	public void DecreaseScore(int amount) //When called decreases score amount set
	{
	score -= amount;
	UpdateScoreText();
	}

	public void UpdateScoreText() // Updates the HUD w/new scores in the UI area text
	{
		scoreText.text = "PLAYER SCORE: "+ score;
	}

}

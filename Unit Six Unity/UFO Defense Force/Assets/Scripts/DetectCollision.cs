using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

	public ScoreManager scoreManager; //Store reference to score manager

	public int scoreToGive;

	void Start()
	{
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Finds the score manager game object and references ScoreManager script
	}
		
    void OnTriggerEnter(Collider other)
    {
		scoreManager.IncreaseScore(scoreToGive); //Increases the scores
        Destroy(gameObject);//If has trigger it will detect collision (Make sure player does not have is Trigger"
        Destroy(other.gameObject);//Destroys two objects - it hits
    }
}

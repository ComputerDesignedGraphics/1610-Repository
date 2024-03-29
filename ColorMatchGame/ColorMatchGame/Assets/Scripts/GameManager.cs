using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{

    public bool isGameOver;

    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");

    }
    // Update is called once per frame

    void Update()
    {
        if (isGameOver)
        {
            EndGame();  // Start EndGame Method
        }
        else
            gameOverText.gameObject.SetActive(false);
        }

        public void EndGame()
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
    	}
}
    
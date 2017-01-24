using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {
    public Text Scoreboard; 
    private int playerScore = 0;
    private int enemyScore = 0;
    GameObject ballObj;

	// Use this for initialization
	void Start () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
    }
	
	// Update is called once per frame
	void Update () {
        if (ballObj.transform.position.x >= 10f)
        {
            playerScore++;

        }
        if (ballObj.transform.position.x <= -10f)
        {
            enemyScore++;
        }
        Scoreboard.text = playerScore.ToString() + " - " + enemyScore.ToString();
        if (playerScore >= 7)
        {
            SceneManager.LoadScene(2);
        }
        if (enemyScore >= 7)
        {
            SceneManager.LoadScene(3);
        }
	}
}

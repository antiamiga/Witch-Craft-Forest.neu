using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    private float score;
    public Text finalScore;
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }

        else
        {
            finalScore.text = scoreText.text + " scored/Highscore: " + Mathf.Round(HighscoreTracker.score);
            if (score > HighscoreTracker.score)
            {
                HighscoreTracker.score = score;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score; // ScoreManageriin liittyvä koodi
    public TMP_Text scoreText;// ScoreManager koodiin liittyvä
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // ScoreManageriin liittyvä koodi
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}//valmis!

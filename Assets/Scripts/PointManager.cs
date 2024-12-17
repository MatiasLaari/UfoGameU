using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score; // ScoreManageriin liittyv� koodi
    public TMP_Text scoreText;// ScoreManager koodiin liittyv�
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // ScoreManageriin liittyv� koodi
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}//valmis!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookiescript : MonoBehaviour
{
    int score;
    public Text scoreText;
    int inc = 1;
    public Text incText;

    public void ScoreUp()
    {
        score += inc;
        scoreText.text = score.ToString();
        //print(score);
    }
    public void Shop()
    {
        if (score >= 5)
        {
            score -= 5;
            inc += 1;
            scoreText.text = score.ToString();
            incText.text = "Inc: " + inc;
        }
    }
}

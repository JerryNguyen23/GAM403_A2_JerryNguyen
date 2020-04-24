using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public void AddScore(int points)
    {
        score += points;
        scoretext.text = score.ToString();
    }

   
}

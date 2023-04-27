using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;

    public Text scoreText;
    public int currentScore;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score:" + currentScore.ToString();
    }

    public void AddScore()
    {
        currentScore += 10;
        scoreText.text = "Score:" + currentScore.ToString();
    }

}

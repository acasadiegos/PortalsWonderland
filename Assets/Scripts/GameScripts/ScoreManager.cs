using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager score;
    int scorePlayer1;
    void Start()
    {
        score = this;
        this.scorePlayer1 = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RaiseScorePlayer1(int s)
    {
        scorePlayer1+= s;
    }

    public void DecreaseScorePlayer1()
    {
        scorePlayer1 -= 1;
    }

    public int GetScorePlayer1()
    {
        return scorePlayer1;
    }
}

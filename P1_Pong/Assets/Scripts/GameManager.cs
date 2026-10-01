using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Score score;
    public Ball ball;
    public GameStates gameState;

    private void Start()
    {
        StartRound();
    }

    public void StartRound()
    {
        ball.ResetBall();
        ball.AddStartingForce();
    }

    // public void CourtTriggered(int courtId)
    // {
    //     score.IncreaseScore((courtId == 0 ? 1 : 0)); //If left court was triggered, right player scores & vice versa
    //     StartRound();
    // }

    public void CourtTriggered(int courtId)
{
    if (courtId == 0)
    {
        // Ball entered left court → Player 2 scores
        score.IncreaseScore(1);
    }
    else if (courtId == 1)
    {
        // Ball entered right court → Player 1 scores
        score.IncreaseScore(0);
    }

    StartRound();
}

}
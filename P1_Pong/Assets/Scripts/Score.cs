using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scorePlayerOne;
    public int scorePlayerTwo;

    public TextMeshProUGUI scorePlayerOneText;
    public TextMeshProUGUI scorePlayerTwoText;
    
    public void IncreaseScore(int playerId)
    {
        switch (playerId)
        {
            case 0:
                scorePlayerOne++;
                break;
            case 1:
                scorePlayerTwo++;
                break;
        }
        
        UpdateScore();
    }

    // public void ResetScore()
    // {
    //     scorePlayerOne = 0;
    //     scorePlayerTwo = 0;
    // }

    public void ResetScore()
{
    scorePlayerOne = 0;
    scorePlayerTwo = 0;

    UpdateScore();
}


    // // Update is called once per frame
    // void UpdateScore()
    // {
    //     scorePlayerOneText.text = scorePlayerOne.ToString();
    //     scorePlayerTwoText.text = scorePlayerTwo.ToString();
    // }

    private void UpdateScore()
{
    scorePlayerOneText.text = scorePlayerOne.ToString();
    scorePlayerTwoText.text = scorePlayerTwo.ToString();
}

}
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text currScore;
    public Text highScore;

    private void OnEnable()
    {
        int score = ScoreCounter.score;

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
        else
        {
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        currScore.text = score.ToString();
    }
}

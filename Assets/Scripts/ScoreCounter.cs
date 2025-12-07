using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    public Text scoreText; 
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("counter"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}

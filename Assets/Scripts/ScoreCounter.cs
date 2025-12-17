using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Flappy fl;
    public SoundManager sound;
    public static int score;
    public Text scoreText; 
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("counter"))
        {
            if(fl.isDead == false)
            {
               score++;
               scoreText.text = score.ToString();
               sound.Play_Point();
            }
        }
    }
}

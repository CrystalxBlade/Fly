using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Home : MonoBehaviour
{
    [SerializeField] Text scoreText; 
    void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

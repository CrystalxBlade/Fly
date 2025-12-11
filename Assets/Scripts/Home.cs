using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    void Start()
    {
        
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

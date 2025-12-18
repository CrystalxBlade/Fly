using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    [SerializeField] GameObject button;

    private void Awake()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            Destroy(gameObject);
            button.SetActive(true);
        }
    }
}

using System.Threading;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float timer, height;
    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            spawn();
        }
    }
    
    void spawn()
    {
        Instantiate(pipe, transform.position + new Vector3(0, Random.Range(-height,height)), Quaternion.identity);
    }
}

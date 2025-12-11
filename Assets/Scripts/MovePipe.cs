using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] float pipeSpeed;
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime; 
        Destroy(gameObject, 4f);

        
        
    }
}

using UnityEngine;

public class Parallex : MonoBehaviour
{
    [SerializeField] float parallexSpeed;
    Vector3 startPos;
    [SerializeField] float endPos;
    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        transform.position += Vector3.left * parallexSpeed * Time.deltaTime;

        if(transform.position.x <= endPos)
        {
            transform.position = startPos;
        }
    }
}

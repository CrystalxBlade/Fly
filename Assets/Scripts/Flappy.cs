using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] public bool isDead = false;
    Animator anim;
    Collider2D coll;
    Rigidbody2D rb; 
    [SerializeField] GameObject gameOverScreen;
    public SoundManager sound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isDead == false)
        {
            rb.linearVelocity = Vector2.up * speed;
            sound.Play_Flap();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.linearVelocity = Vector2.up * speed;
        isDead = true;
        coll.enabled = false;
        anim.Play("Die");
        gameOverScreen.SetActive(true);
        sound.Play_Hit();
        sound.Play_Slap();
    }
}

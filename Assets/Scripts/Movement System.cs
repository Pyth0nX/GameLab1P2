using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementSystem : MonoBehaviour
{
    public float speed;
    public float jump;
    private float move;
    public Rigidbody2D rb;
    private SpriteRenderer sprite;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("DeathBarrier"))
        {
            SceneManager.LoadScene("RetryGame");
        }
        if (collision.gameObject.CompareTag("House"))
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.CompareTag("FinishLine"))
        {
            SceneManager.LoadScene("LevelSelector");
        }
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));

            isGrounded = false;
        }
        if (rb.velocity.x < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }

}
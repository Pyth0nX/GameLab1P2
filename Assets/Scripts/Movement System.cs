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

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

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
    }

}
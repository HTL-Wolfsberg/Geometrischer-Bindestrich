using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 jump;
    public float speed = 5f;
    public float jumpForce = 2.0f;

    public GameOverPanel gamO;

    public bool isGrounded;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            gamO.gameOver = true;
        }
    }
}
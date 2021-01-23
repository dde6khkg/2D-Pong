using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPaddle : MonoBehaviour
{
    public float speed;

    private float movement;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxisRaw("UserPaddle");

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);

    }
}

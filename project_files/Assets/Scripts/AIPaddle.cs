using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle: MonoBehaviour
{
    public float speed;

    private bool direction;
    private Rigidbody2D rb;
    private GameObject Ball;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Ball = GameObject.Find("Ball");
    }

    void Update()
    {
        direction = Ball.transform.position.y > rb.transform.position.y;
        rb.velocity = new Vector2(rb.velocity.x, (direction ? 1 : -1) * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector3 startPosition;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        Launch();
    }

    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Обработка столкновений с различными объектами на игровом поле
    }
}

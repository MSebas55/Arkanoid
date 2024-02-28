using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float speed;
    private Vector2 velocity;
    Vector2 startPosition;

    void OnEnable()
    {
        ResetBall();

    }
    void Start()
    {
        startPosition = transform.position;
        ResetBall();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadzone"))
        {
            FindObjectOfType<GameManager>().LoseHealth(gameObject);
        }
    }

    public void ResetBall()
    {
        velocity.x = Random.Range(-1f, 1f);

        velocity.y = 1;

        rigidBody2D.AddForce(velocity * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float _velocity = 2.5f;
    public float _rotationSpeed = 10f;
    private float inputValue;
    public float moveSpeed = 25;
    private Vector2 direction;
    Vector2 startPosition;
    private static Player instance;
    public static Player Instance { get { return instance; } }
    private void Start()
    {
        startPosition = transform.position;
    }
    private void Awake()
    {
        // Verifica si la instancia ya está inicializada
        if (instance == null)
        {
            // Si no está inicializada, asigna esta instancia a instance
            instance = this;
        }
        else
        {
            // Si ya hay una instancia, destruye esta instancia para evitar duplicados
            Destroy(gameObject);
        }
    }

    void Update()
    {
        #if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
        {
            direction = Vector2.right;
        } else if (inputValue == -1)
        {
            direction = Vector2.left;
        } else
        {
            direction = Vector2.zero;
        }
        rigidBody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);
#elif UNITY_ANDROID
    foreach (Touch toque in Input.touches)
    {
        if (toque.phase == UnityEngine.TouchPhase.Began || toque.phase == UnityEngine.TouchPhase.Moved)
        {
            rigidBody2D.velocity = Vector2.zero;

            // Obtener la posición del toque en la pantalla
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(toque.position);

            // Si el toque está en la parte izquierda de la pantalla
            if (touchPosition.x < 0)
            {
                // Mover hacia la izquierda
                rigidBody2D.AddForce(Vector2.left * _velocity, ForceMode2D.Impulse);
            }
            // Si el toque está en la parte derecha de la pantalla
            else
            {
                // Mover hacia la derecha
                rigidBody2D.AddForce(Vector2.right * _velocity, ForceMode2D.Impulse);
            }
        }
    }
#endif
    }
    public void ResetPlayer()
    {
        startPosition = transform.position;
        rigidBody2D.velocity = Vector2.zero;
    }
}

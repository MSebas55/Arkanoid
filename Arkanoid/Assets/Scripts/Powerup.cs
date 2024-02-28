using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Powerup : MonoBehaviour
{
    public PowerUpEffect PowerUpEffect;
    bool powerUpApplied = false;
    GameObject obj;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Verifica si el objeto que colisiona tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player") && !powerUpApplied)
        {
            Destroy(gameObject); // Destruye el objeto actual
            if (gameObject.name.Contains("MoreBalls"))
            {
                PowerUpEffect.Apply(BallPool.Instance.RequestBall()); // Aplica el efecto del power-up al jugador
                
            }
            else if(gameObject.name.Contains("ExtendPlayer"))
            {
                
                PowerUpEffect.Apply(obj); // Aplica el efecto del power-up al jugador
            }
            
            powerUpApplied = true; // Marca el power-up como aplicado

        }else if (collision.gameObject.CompareTag("Deadzone"))
        {
            Destroy(gameObject); // Destruye el objeto actual
        }
    }
}


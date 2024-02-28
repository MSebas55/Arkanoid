using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Brick : MonoBehaviour
{
    System.Random rand = new System.Random();
    bool crear;
    public GameObject powerupPrefabVerde; // Asigna el prefab del powerup desde el editor de Unity
    public GameObject powerupPrefabRosa; // Asigna el prefab del powerup desde el editor de Unity

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            GameManager.Instance.BrickBroke();
            crear = rand.Next(0, 2) == 0; // 50% de probabilidad de crear el powerup
            if (crear && powerupPrefabVerde != null && powerupPrefabRosa != null)
            {
                crear = rand.Next(0, 10) == 0; // 10% de probabilidad de elegir powerup verde
                if (crear)
                {
                    // Instancia el powerup en la escena
                    GameObject instanciaPrefab = Instantiate(powerupPrefabRosa, transform.position, Quaternion.identity);

                }
                else
                {
                    // Instancia el powerup en la escena
                    GameObject instanciaPrefab = Instantiate(powerupPrefabVerde, transform.position, Quaternion.identity);

                }
            }
        }
    }

}

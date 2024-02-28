using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static GameObject canvas;
    public void changeScene()
    {
        // Recargar la escena "Juego"
        SceneManager.LoadScene("Juego");
    }
}

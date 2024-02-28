using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public void LoseHealth(GameObject ball)
    {
        ball.SetActive(false);
        

        
        findBall();
        findBrick();
    } 

    public void findBall()
    {
        Ball ball = FindObjectOfType<Ball>();
        if (ball == null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void findBrick()
    {
        Brick brick = FindObjectOfType<Brick>();
        if (brick == null)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}

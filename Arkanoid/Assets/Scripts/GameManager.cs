using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void LoseHealth(GameObject ball)
    {
        ball.SetActive(false);
        findBall();
    }

    public void BrickBroke()
    {
        findBrick();
    }
    

    public void findBall()
    {
        Ball ball = FindAnyObjectByType<Ball>();
        if (ball == null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void findBrick()
    {
        Brick brick = FindAnyObjectByType<Brick>();
        if (brick == null)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}

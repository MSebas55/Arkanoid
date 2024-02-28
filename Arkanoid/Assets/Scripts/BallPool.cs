using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPool : MonoBehaviour
{
    public List<GameObject> pool;
    public GameObject obj;
    private uint poolSize;
    private static BallPool instance;
    public static BallPool Instance {  get { return instance; } }

    void Start()
    {
        poolSize = 15;
        AddGameObjectToPool();
        
    }
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject RequestBall()
    {
        for(int i = 0; i < poolSize; i++)
        {
            if (!pool[i].activeSelf)
            {
                pool[i].SetActive(true);
                return pool[i];
            }
            
        }
        
        return null;
    }

    private void AddGameObjectToPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ball = Instantiate(obj);
            ball.SetActive(false);
            pool.Add(ball);
            ball.transform.parent = transform;
        }
    }
}
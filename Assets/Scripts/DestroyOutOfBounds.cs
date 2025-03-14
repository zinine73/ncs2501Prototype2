using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GameOverAction : UnityEngine.Events.UnityEvent{}
public class DestroyOutOfBounds : MonoBehaviour
{
    //private SpawnManager sm;
    //public static GameOverAction OnGameOver = new GameOverAction();
    public delegate void GameOverHandler();
    public static event GameOverHandler OnGameOver;
    
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
        //sm = GameObject.FindGameObjectWithTag("SM").GetComponent<SpawnManager>();
        //sm = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            //sm.DisplayGameOver();
            //OnGameOver.Invoke();
            OnGameOver();
            
            Destroy(gameObject);
        }
    }
}

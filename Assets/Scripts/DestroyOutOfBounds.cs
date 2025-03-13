using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private SpawnManager sm;
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("SM").GetComponent<SpawnManager>();
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
            sm.DisplayGameOver();
            Destroy(gameObject);
        }
    }
}

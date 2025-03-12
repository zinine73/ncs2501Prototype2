using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 25.0f;
    public float xRange = 15.0f;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        // x좌표를 넘지 않게 한다
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // 발사체
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, 
                projectilePrefab.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject PanelGameOver;

    private float spawnRangeX = 15.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        PanelGameOver.SetActive(false);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);    
    }

    private void Update()
    {
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex],
        spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }

    public void DisplayGameOver()
    {
        PanelGameOver.SetActive(true);
    }
}

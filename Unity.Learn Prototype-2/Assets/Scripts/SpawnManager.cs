using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnposX = 15f;
    private float spawnposZ = 30f;
    private float startDelay = 2f;
    private float timeGap = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,timeGap);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal() {

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnposX, spawnposX), 0, spawnposZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;


    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnPosY = 20;

    private float startDelay = 2;
    private float spawnIntervar = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnIntervar);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
    void SpamAnimalLeftRight()
    {
        int animalIndexZ = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosZ = new(Random.Range(-spawnRangeX, spawnRangeX), 0, 2);

        Instantiate(animalPrefabs[animalIndexZ], spawnPosZ,
            animalPrefabs[animalIndexZ].transform.rotation);


    }
}

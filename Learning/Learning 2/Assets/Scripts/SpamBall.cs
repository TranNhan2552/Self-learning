using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamBall : MonoBehaviour
{
    public GameObject[] spamBall;

    private float spamX = 30;

    private float startDelay = 2f;
    private float spawnIntevar = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spamRandomBall",startDelay,spawnIntevar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spamRandomBall()
    {
        int ballIndex = Random.Range(0, spamBall.Length);
        Vector3 SpawnPosition = new(Random.Range(-startDelay, startDelay), 0, 0);

        Instantiate(spamBall[ballIndex], SpawnPosition,
            spamBall[ballIndex].transform.rotation);
    }
}

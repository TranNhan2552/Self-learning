using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBuonds = 20.0f;
    public float downBounds = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBuonds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < downBounds)
        {
            Debug.Log("Game Over !!!");
            Destroy(gameObject);
        }
        
    
    }
}

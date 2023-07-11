using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontallInput;
    private float verticalInput;
    private float speed = 20.0f;
    private float xRange = 22;
    private float zRangeTop = 1;
    private float zRangeBot = -7;

    public Transform projecttitleSpawnPoint;

    public GameObject projectPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,zRangeTop);
        }
        if(transform.position.z < zRangeBot)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBot);
        }


        horizontallInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontallInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(projectPrefabs, projecttitleSpawnPoint.position, projectPrefabs.transform.rotation);   
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 GocNhinThuNhat = new Vector3(0, 2   , 1);
    private Vector3 GocNhinThuBa = new Vector3(0, 7, -11);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + GocNhinThuBa;

        if (Input.GetKey(KeyCode.T)) {
            GetComponent<Camera>().enabled = true;
        }
        

    }

}

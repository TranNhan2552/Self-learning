using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;
    private float turnSpeed = 70.0f;
    private float horizontalInput, forwardInput;
    public Camera cameramain;
    public Camera camerahood;
    
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

         // chạy về phía trước
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );

        //  quay qua trái phải
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // chuyển đổi góc nhìn
        if (Input.GetKey(KeyCode.T))
        {
            cameramain.enabled = !cameramain.enabled;
            camerahood.enabled = !camerahood.enabled;

        }
        
        
        

    }
}

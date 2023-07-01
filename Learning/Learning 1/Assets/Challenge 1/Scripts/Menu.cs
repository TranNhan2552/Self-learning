using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    private bool isMenu = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isMenu)
            {
                isMenu = true;
                menu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                isMenu = false;
                menu.SetActive(false);
                Time.timeScale = 1;
            }


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopScreenScript : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.Find("Laptop Screen");
        screen.SetActive(false);
    }

    public void ScreenFunction()
    {
        if (screen.activeSelf == true)
        {
            screen.SetActive(false);
        }
        else screen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

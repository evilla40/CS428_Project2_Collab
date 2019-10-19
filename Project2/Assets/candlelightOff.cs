using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candlelightOff : MonoBehaviour
{
    public GameObject candleLight;
    // Start is called before the first frame update
    public void candleLinghtOff()
    {
        candleLight.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Kibble : MonoBehaviour
{
    public GameObject[] array = new GameObject[]
    {
        GameObject.Find("Kibble"), GameObject.Find("Kibble1"), GameObject.Find("Sphere1"),
        GameObject.Find("Kibble2"), GameObject.Find("Kibble3"), GameObject.Find("Sphere2"),
        GameObject.Find("Kibble4"), GameObject.Find("Kibble5"), GameObject.Find("Sphere3"),
        GameObject.Find("Kibble6"), GameObject.Find("Kibble7")
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Eat()
    {
        int n;
        while (true)
        {
            n = Random.Range(0, 10);
            if (array[n].activeSelf == true)
            {
                array[n].SetActive(false);
                break;
            }
            else continue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

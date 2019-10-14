using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour
{
    public GameObject obj;
    private Color c;

    // Start is called before the first frame update
    void Start()
    {
        c = obj.GetComponent<Renderer>().material.GetColor("Bone Material");
    }

    public void changeColor()
    {
        var x = obj.GetComponent<Renderer>();
        int n = Random.Range(1, 5);
        if (n == 1) x.material.color = new UnityEngine.Color(100, 0, 0);
        else if (n == 2) x.material.color = new UnityEngine.Color(0, 100, 0);
        else if (n == 3) x.material.color = new UnityEngine.Color(0, 0, 100);
        else x.material.color = c;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

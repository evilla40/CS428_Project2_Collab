using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_PickUp : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Move()
    {
        obj.transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

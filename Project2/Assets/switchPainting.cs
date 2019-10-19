using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPainting : MonoBehaviour
{
    public GameObject stillPainting;
    public GameObject movingPainting;
    public GameObject slidingSound;
    // Start is called before the first frame update
    public void movePainting()
    {
        if (!movingPainting.activeInHierarchy)
        {
            slidingSound.SetActive(true);
            movingPainting.SetActive(true);
            stillPainting.SetActive(false);
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

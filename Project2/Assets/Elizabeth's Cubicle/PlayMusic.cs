using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        if (obj.name == "clock")
        { 
            source.loop = true;
        }
        if (source.isPlaying == true)
        {
            source.Stop();
        }
        else
            source.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

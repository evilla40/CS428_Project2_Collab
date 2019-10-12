using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        if (source.isPlaying == true)
        {
            source.Stop();
        }
        else
            source.PlayOneShot(clip);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

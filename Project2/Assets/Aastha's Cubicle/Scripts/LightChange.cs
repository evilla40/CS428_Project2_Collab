using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{

    public Light Light;
    public bool changeRange = false;
    public float rangeSpeed = 1.0f;
    public float maxRange=10.0f;
    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;
    public bool changeColor = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    float startTime;

    void Start()
    {
        Light = GetComponent<Light>();
        startTime = Time.time;
    }

    
    void Update()
    {
        if (changeRange) {
            Light.range = Mathf.PingPong(Time.time * rangeSpeed, maxRange); }
        if (changeIntensity) {
            Light.intensity = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity);
        }
        if (changeColor) {
            float t = Mathf.Sin(Time.time - startTime * colorSpeed);
            Light.color = Color.Lerp(startColor, endColor, t);
        }

    }
}

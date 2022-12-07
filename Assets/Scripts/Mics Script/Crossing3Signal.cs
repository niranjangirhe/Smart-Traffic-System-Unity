using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Crossing3Signal : MonoBehaviour
{
    public Light red;
    public Light green;
    public GameObject sensor;
    private float timer=0;
    public TextMeshPro txt;
    private float sum;
    private int count;

    private bool isfirst = true;

    void Start()
    {
        sum = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sensor.GetComponent<SensorLightVisualizerCrossing3>().blink)
        {
            if (!isfirst)
            {
                count++;
                sum += 1000 / timer;
            }
            isfirst = true;
            green.intensity = 5;
            red.intensity = 0;
        }
        else
        {
            red.intensity = 5;
            green.intensity = 0;
            if (isfirst)
                timer = 0;
            timer += Time.deltaTime;
            isfirst = false;
        }
        txt.text = "Time taken : " + timer.ToString("F2") + "sec\nTraffic Rate : " + (1000 / timer).ToString("F2") + "\nAvg Traffic Rate : "+(sum/count).ToString("F2");

    }

}

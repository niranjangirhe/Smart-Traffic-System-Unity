using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableQueue : MonoBehaviour
{
    public Toggle t1;
    public GameObject g,sensor;
    private bool beeninside;
    void Start()
    {
        beeninside = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(t1.isOn)
        {
            g.SetActive(true);
            beeninside = true;
        }
        else
        {
            g.SetActive(false);
            if(beeninside)
            {
                sensor.GetComponent<SensorLightVisualizer>().shouldGlow = false;
                beeninside = false;
            }
        }
    }
}

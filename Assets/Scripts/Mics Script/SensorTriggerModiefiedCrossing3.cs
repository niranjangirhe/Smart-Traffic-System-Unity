using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Start is called before the first frame update


public class SensorTriggerModiefiedCrossing3 : MonoBehaviour
{


    private GameObject obgj;
    private bool startlog=false;
    float SensorTime = 0;
    private float timelimit=10;

    // [DebugGUIPrint, DebugGUIGraph(group: 1, r: 0, g: 1, b: 0)]
    // float mouseY;

   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
        if (startlog && obgj != null)
        {
            if (timelimit > SensorTime)
                SensorTime += Time.deltaTime;
            else
                SensorTime = timelimit;
        }
        else
        {
            SensorTime = 0;
        }
     

    }


    void OnTriggerEnter(Collider other)
    {
   
        if (other.tag == "Sensor")
        {
            obgj = other.gameObject;
            startlog = true;
            other.GetComponent<SensorLightVisualizerCrossing3>().shouldGlow = true;
            timelimit = other.GetComponent<SensorLightVisualizerCrossing3>().timelimit;
        }
       
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit: " + other.name);
        if(other.tag=="Sensor")
        {
            other.GetComponent<SensorLightVisualizerCrossing3>().shouldGlow = false;
            timelimit = other.GetComponent<SensorLightVisualizerCrossing3>().timelimit;
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Start is called before the first frame update


public class SensorTriggerModiefied : MonoBehaviour
{

    [DebugGUIPrint, DebugGUIGraph(group: 0, r: 1f, g: 0.5f, b: 0.7f, autoScale: true)]
    float RawData;
    private GameObject obgj;
    private bool startlog=false;
    [DebugGUIPrint, DebugGUIGraph(group: 1, r: 1f, g: 1f, b: 1f, min: 0, max: 5, autoScale: true)]
    float SensorTime = 0;
    private float timelimit=10;

    

   
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
            RawData = Vector3.Distance(gameObject.transform.position, obgj.transform.position);
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
            other.GetComponent<SensorLightVisualizer>().shouldGlow = true;
            timelimit = other.GetComponent<SensorLightVisualizer>().timelimit;
        }
       
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit: " + other.name);
        if(other.tag=="Sensor")
        {
            RawData = 0;
            other.GetComponent<SensorLightVisualizer>().shouldGlow = false;
            timelimit = other.GetComponent<SensorLightVisualizer>().timelimit;
        }
       
    }
}

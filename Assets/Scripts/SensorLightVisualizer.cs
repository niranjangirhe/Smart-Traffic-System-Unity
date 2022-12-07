using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorLightVisualizer : MonoBehaviour
{
    // Start is called before the first frame update
    public new Light light;
    public bool shouldGlow=false;
    public int mf;
    private Color lightinit;
    public Color red;
    public Color black;
    public float timelimit;
    public float blinkspped;
    private float timer;
    public bool blink = false;
    void Start()
    {
        lightinit = light.color;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (shouldGlow)
        {
            if (light.intensity < 10)
                light.intensity += Time.deltaTime*mf*2;
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if(timer>=timelimit)
            {
                blink = true;
                if (timer%blinkspped>=blinkspped/2)
                {
                    light.color = red;
                }
                else
                {
                    light.color = black;
                }
            }
            else
                blink = false;

        }
        else if (!shouldGlow)
        {
            blink = false;
            timer = 0;
            light.color = lightinit;
            if(light.intensity > 0)
                light.intensity -= Time.deltaTime*mf;
        }
    }
}

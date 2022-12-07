using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorLightVisualizerCrossing3 : MonoBehaviour
{
    // Start is called before the first frame update
    public new Light light;
    public bool shouldGlow=false;
    public int mf;
    private Color lightinit;
    public Color red;
    public Color black;
    public float timelimit;
    public float blinktime;
    public float blinkspped;
    private float timer;
    public bool blink = false;
    public GameObject e1, e2;
    private bool called = true;
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
            if (timer >= timelimit)
            {
                
                if(timer >= timelimit + blinktime)
                {
                    Debug.Log("jnds");
                    shouldGlow = false;
                }
                blink = true;
                if (called)
                {
                    called = false;
                    e1.GetComponent<CarEmiterC3>().reached = true;
                    e2.GetComponent<CarEmiterC3>().reached = true;
                }
                if (timer % blinkspped >= blinkspped / 2)
                {
                    light.color = red;
                }
                else
                {
                    light.color = black;
                }
            }
            else
            {
                blink = false;
                called = true;
            }

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

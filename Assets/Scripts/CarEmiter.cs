using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEmiter : MonoBehaviour
{
    public GameObject car;
    private float timer = 0;
    public float emitspeed;
    private int rand;
    void Start()
    {
        rand = Random.Range(50, 150);
        Instantiate(car, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= emitspeed*rand/100)
        {
            rand = Random.Range(50, 150);
            timer = 0;
            Instantiate(car, transform.position, transform.rotation);
        }
    }
}

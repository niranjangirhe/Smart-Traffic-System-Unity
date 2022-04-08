using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing1CarMov : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, car.transform.position , Time.deltaTime);
    }
}

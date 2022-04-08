using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing3N1 : MonoBehaviour
{
    public GameObject endP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(endP!=null)
            transform.position = Vector3.Lerp(transform.position, endP.transform.position, Time.deltaTime);
    }
}

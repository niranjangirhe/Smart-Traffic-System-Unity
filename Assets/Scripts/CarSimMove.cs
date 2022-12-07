using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSimMove : MonoBehaviour
{
    public float speed;
    private bool incrossing = false;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = new Vector3(transform.position.x-Time.deltaTime* speed, transform.position.y, transform.position.z); 
        if(timer>=8)
        {
            Destroy(gameObject);
        }
        if(incrossing)
        {
            
        }
       
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + other.name);
        if (other.tag == "crossing")
        {
            incrossing = true;
        }
    }
}

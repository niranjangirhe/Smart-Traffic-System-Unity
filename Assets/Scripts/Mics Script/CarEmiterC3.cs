using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEmiterC3 : MonoBehaviour
{
    public GameObject car;
    private float timer = 0;
    public float emitspeed;
    private int rand;
    public GameObject endp;
    private GameObject endpCopy;
    public bool reached = false;
    public List<GameObject> cars= new List<GameObject>();
    void Start()
    {
        rand = Random.Range(25, 175);
        Instantiate(car, transform.position, transform.rotation);
        endpCopy = endp;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= emitspeed*rand/100)
        {
            rand = Random.Range(50, 150);
            timer = 0;
            GameObject s = Instantiate(car, transform.position, transform.rotation);
            cars.Add(s);
            s.GetComponent<Crossing3N1>().endP = endp;
            for(int i=0; i < s.transform.childCount;i++)
            {
                if(s.transform.GetChild(i).gameObject.name=="tail")
                {
                    endp = s.transform.GetChild(i).gameObject;
                    break;
                }
            }
            if(reached)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    Destroy(cars[i]);
                }
                cars.Clear();
                endp = endpCopy;
                timer = -5;
                reached = false;
            }    
        }
    }
}

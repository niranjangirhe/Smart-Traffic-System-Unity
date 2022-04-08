using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceDetect : MonoBehaviour
{
    public Transform s1, s2, s3, s4;
    public LineRenderer l1;
    public Light g4, g1, g2, g3;
    public Light r4, r1, r2, r3;
    public Transform d;
    public float dis;
    void redon()
    {
        r1.intensity = 5;
        r2.intensity = 5;
        r3.intensity = 5;
        r4.intensity = 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        redon();
    }
    void greenof()
    {
        g1.intensity = 0;
        g2.intensity = 0;
        g3.intensity = 0;
        g4.intensity = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(d.position, transform.position) < dis)
        {
            float d1 = Vector3.Distance(s1.position, transform.position);
            float d2 = Vector3.Distance(s2.position, transform.position);
            float d3 = Vector3.Distance(s3.position, transform.position);
            float d4 = Vector3.Distance(s4.position, transform.position);
            if (d1 < d2 && d1 < d3 && d1 < d4)
            {
                greenof();
                redon();
                g1.intensity = 5;
                r1.intensity = 0;
                l1.enabled = true;
                l1.SetPosition(0, transform.position);
                l1.SetPosition(1, s1.position);

            }
            else if (d2 < d1 && d2 < d3 && d2 < d4)
            {
                greenof();
                redon();
                g2.intensity = 5;
                r2.intensity = 0;
                l1.enabled = true;
                l1.SetPosition(0, transform.position);
                l1.SetPosition(1, s2.position);

            }
            else if (d3 < d2 && d3 < d1 && d3 < d4)
            {
                greenof();
                redon();
                g3.intensity = 5;
                r3.intensity = 0;
                l1.enabled = true;
                l1.SetPosition(0, transform.position);
                l1.SetPosition(1, s3.position);

            }
            else
            {
                greenof();
                redon();
                g4.intensity = 5;
                r4.intensity = 0;
                l1.enabled = true;
                l1.SetPosition(0, transform.position);
                l1.SetPosition(1, s4.position);
            }
        }
        else
        {
            l1.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighwaySignal : MonoBehaviour
{
    public Light[] red;
    public Light[] green;
    public float mf,timelimit;
    public GameObject[] sensor;
    private float timer=0;
    public bool[] buff;
    public TextMeshPro txt;
    public GameObject[] queueMics;
    public Toggle t;

    void Start()
    {
        txt.text = timelimit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(sensor[0].GetComponent<SensorLightVisualizer>().blink || buff[0])
        {
            t.isOn = false;
            queueMics[0].SetActive(false);
            queueMics[1].SetActive(false);
            queueMics[2].SetActive(false);
            queueMics[3].SetActive(false);
            if (buff[0] == false)
            {
                timer = 0;
            }
            SignalTurn(0);
            buff[0] = true;
            if(timer>=timelimit)
            {
                buff[0] = false;
            }
        }
        else if (sensor[1].GetComponent<SensorLightVisualizer>().blink || buff[1])
        {
            if (buff[1] == false)
            {
                timer = 0;
            }
            SignalTurn(1);
            buff[1] = true;
            if (timer >= timelimit)
            {
                buff[1] = false;
            }
        }
        else if (sensor[2].GetComponent<SensorLightVisualizer>().blink || buff[2])
        {
            if (buff[2] == false)
            {
                timer = 0;
            }
            SignalTurn(2);
            buff[2] = true;
            if (timer >= timelimit)
            {
                buff[2] = false;
            }
        }
        else if (sensor[3].GetComponent<SensorLightVisualizer>().blink || buff[3])
        {
            if (buff[3] == false)
            {
                timer = 0;
            }
            SignalTurn(3);
            buff[3] = true;
            if (timer >= timelimit)
            {
                buff[3] = false;
            }
        }
        else if(!buff[0] && !buff[1] && !buff[2] && !buff[3]) 
        {
            SignalBoth();
            txt.text = "No-stop HighWay";
        }
        if (buff[0] || buff[1] || buff[2] || buff[3])
        {
            txt.text = Mathf.RoundToInt(timelimit - timer).ToString();
        }
        /*
        time += Time.deltaTime * mf;
        Debug.Log(time);
        if (time % 400 < 100)
        {
            SignalTurn(0);
        }
        else if (time % 400 < 200)
        {
            SignalTurn(1);
        }
        else if (time % 400 < 300)
        {
            SignalTurn(2);
        }
        else
        {
            SignalTurn(3);
        }
        */
    }
    private void SignalTurn(int i)
    {
        Alloff();
        green[i].intensity = 5;
        TurnRed(i);
    }
    private void SignalBoth()
    {
        Alloff();
        green[1].intensity = 5;
        green[3].intensity = 5;
        red[0].intensity = 5;
        red[2].intensity = 5;
    }
    private void TurnRed(int i)
    {
        for (int j = 0; j < 4; j++)
        {
            if (j != i)
                red[j].intensity = 5;
        }
    }

    private void Alloff()
    {
        for (int i = 0; i < 4; i++)
        {
            red[i].intensity = 0;
            green[i].intensity = 0;
        }
    }
}

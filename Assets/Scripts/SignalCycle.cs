using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SignalCycle : MonoBehaviour
{
    public Light[] red;
    public Light[] green;
    private float time = 0;
    private float mf;
    public int[] percentage;
    public int sliderTotal;
    public Slider[] sliderval;
    public TextMeshPro[] txt;
    private string[] st = { "A ", "B ", "C ", "D " };
    void Start()
    {
        for(int i=0;i<4;i++)
        {
            sliderTotal += Mathf.RoundToInt(sliderval[i].value);
            percentage[i] = 25;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderTotal = 0;
        mf = sliderval[4].value;
        for (int i = 0; i < 4; i++)
        {
            sliderTotal += Mathf.RoundToInt(sliderval[i].value);
        }
        for (int i = 0; i < 4; i++)
        {
            percentage[i] = Mathf.RoundToInt(sliderval[i].value)*100 / sliderTotal;
            txt[i].text = st[i]+Mathf.RoundToInt(percentage[i] / mf).ToString();
            //Debug.Log(percentage[i]);
        }
        time += Time.deltaTime* mf;
        if(time%100< percentage[0])
        {
            txt[4].text = Mathf.RoundToInt((time % 100)/mf).ToString();
            SignalTurn(0);
        }
        else if(time % 100 < percentage[0]+ percentage[1])
        {
            txt[4].text =Mathf.RoundToInt((time % 100 - percentage[0]) / mf).ToString();
            SignalTurn(1);
        }
        else if (time % 100 < percentage[0] + percentage[1] + percentage[2])
        {
            txt[4].text = Mathf.RoundToInt((time % 100 - percentage[0] - percentage[1]) / mf).ToString();
            SignalTurn(2);
        }
        else
        {
            txt[4].text = Mathf.RoundToInt((time % 100 - percentage[0] - percentage[1] - percentage[2]) / mf).ToString();
            SignalTurn(3);
        }
    }
    private void SignalTurn(int i)
    {
        Alloff();
        green[i].intensity = 5;
        TurnRed(i);
    }

    private void TurnRed(int i)
    {
        for (int j = 0; j < 4; j++)
        {
            if(j!=i)
                red[j].intensity = 5;
        }
    }

    private void Alloff()
    {
        for(int i=0;i<4;i++)
        {
            red[i].intensity = 0;
            green[i].intensity = 0;
        }
    }
}

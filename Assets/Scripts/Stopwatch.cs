using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    public bool stopwatchActive = false;
    float currentTime;
    public TextMeshProUGUI currentTimeText;
    public Delivery delivery;
    
    // Start is called before the first frame update
    public void Start()
    {
        currentTime = 0;
        
        GameObject goCar = GameObject.Find("Speedy");
        delivery = goCar.GetComponent<Delivery>();
       
    }

    // Update is called once per frame
    public void Update()
    {
        if(delivery.firstPackage)
        {
            stopwatchActive = true;
        }
        else 
        {
            stopwatchActive = false;
        }

        if(stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "Time: " + time.ToString(@"mm\:ss\:fff");
    }
    public void StartStopwatch()
    {
        stopwatchActive = true;
    }
    public void stopStopwatch()
    {
        stopwatchActive = false;
    }





}

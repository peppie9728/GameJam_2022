using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    bool timerActive = true;
    float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    private void Start()
    {
        currentTime = startMinutes * 60;
    }

    private void Update()
    {
        if (timerActive == true)
        { 
        currentTime = currentTime + Time.deltaTime;
        }
        currentTimeText.text = currentTime.ToString();
    }

    
    public void StopTimer()
    {
        //if je bij het einde ben stopt timer
        {
            timerActive = false;
        }
    }
      
    //display timer bij eindscherm
}   
    
    
    
    
    
    
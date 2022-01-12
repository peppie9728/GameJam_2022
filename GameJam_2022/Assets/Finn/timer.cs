using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public bool timerActive = true;
    public float currentTime;
    public float currentTime2;
    public int startMinutes;
    public Text currentTimeText;
    public Text currentTimeText2;
    
    
    private void Start()
    {
        currentTime = startMinutes * 60;
    }



private void Update()
    {
        if (timerActive == true)
        { 
        currentTime = currentTime + Time.deltaTime;
            currentTime2 = currentTime2 + Time.deltaTime;
        }
        currentTimeText.text = currentTime.ToString();
        currentTimeText2.text = currentTime2.ToString();
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("stop");
            timerActive = false;
        }
    }

    



    
}   
    
    
    
    
    
    
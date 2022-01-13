using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject canvasEnd;
    public GameObject canvasTimer;
    public GameObject player;
    public GameObject endCamera;

    
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            canvasEnd.SetActive(true);   //zet het eindscherm  op active 
            canvasTimer.SetActive(false); // zet de timer linksboven uit
            player.SetActive(false); // disabled de speler zodat je niet meer loopt 
            endCamera.SetActive(true); //zet de camera aan aan het einde van de map
           
            
            
        }
    }
}

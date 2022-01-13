using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject canvasEnd;
    public GameObject canvasTimer;
    

    
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            canvasEnd.SetActive(true);   //zet het eindscherm  op active zodat de ui veranderd naar een eindscherm
            canvasTimer.SetActive(false); // zet de timer linksboven uit
                Cursor.lockState = CursorLockMode.Confined;// dit zorgt ervoor dat je de muis weer ziet om op de buttons te kilkken
                Cursor.visible = true;
            
                
            



        }
    }
}

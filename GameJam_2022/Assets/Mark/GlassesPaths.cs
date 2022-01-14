using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlassesPaths : MonoBehaviour
{
    private GlassesUI GlassesUI;
    public int glassesIndex = 1;
    public bool redFound = false;
    public bool blueFound = false;
    public bool greenFound = false;

    public GameObject redObj;
    public GameObject greenObj;
    public GameObject blueObj;

    public GameObject redGlasses;
    public GameObject greenGlasses;
    public GameObject blueGlasses;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index();
       // temp(); 
        Paths();
        GlassesObtained();
    }
    void index()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && glassesIndex <= 4)
        {
            glassesIndex ++;
            Debug.Log(glassesIndex);
            
        }
        else if (Input.GetKeyDown(KeyCode.Q) && glassesIndex >= 1)
        {
            glassesIndex --;
            Debug.Log(glassesIndex);
        }
        else if ( glassesIndex == 5)
        {
            glassesIndex = 1;
        }
       

    }

    void GlassesObtained()
    {
        if (redGlasses.gameObject.activeInHierarchy == false)
        {
            redFound = true;
        }

        if (greenGlasses.gameObject.activeInHierarchy == false)
        {
            greenFound = true;
        }

        if (blueGlasses.gameObject.activeInHierarchy == false)
        {
            blueFound = true;
        }
    }
/*    void temp()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            blueFound = true; 
        }
    } */
    void Paths()
    {
        if (glassesIndex == 1 )
        {
            redObj.SetActive(false);
            greenObj.SetActive(false);
            blueObj.SetActive(false);
        }
        else if (glassesIndex == 2 && redFound == true)
        {
            redObj.SetActive(true);
            greenObj.SetActive(false);
            blueObj.SetActive(false);
        }
        else if (glassesIndex == 3 && greenFound == true)
        {
            redObj.SetActive(false);
            greenObj.SetActive(true);
            blueObj.SetActive(false);
        }
        else if (glassesIndex == 4 && blueFound == true)
        {
            redObj.SetActive(false);
            greenObj.SetActive(false);
            blueObj.SetActive(true);
        }
        
    }

    


}



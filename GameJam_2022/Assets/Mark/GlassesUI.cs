using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlassesUI : MonoBehaviour
{
    public GlassesPaths GlassesPaths;
    public Text currentGlassesText;
    public GameObject redimage;
    public GameObject greenimage;
    public GameObject blueimage;
    int GlassesValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GlassesValue = GlassesPaths.glassesIndex;
        glassesColorChecker();
    }

    void glassesColorChecker()
    {
        if (GlassesValue == 1 )
        {
            currentGlassesText.text = "You are wearing no glasses";
            redimage.SetActive(false);
            greenimage.SetActive(false);
            blueimage.SetActive(false);
        }
        
        
        if (GlassesValue == 2 && GlassesPaths.redFound == true )
        {
            currentGlassesText.text = "You are wearing red glasses";
            redimage.SetActive(true);
            greenimage.SetActive(false);
            blueimage.SetActive(false);
        }
        else if (GlassesValue == 2 && GlassesPaths.redFound == false){
            currentGlassesText.text = "You do not have red glasses";
            redimage.SetActive(false);
            greenimage.SetActive(false);
            blueimage.SetActive(false);
        }


        if (GlassesValue == 3 && GlassesPaths.greenFound == true)
        {
            currentGlassesText.text = "You are wearing green glasses";
            redimage.SetActive(false);
            greenimage.SetActive(true);
            blueimage.SetActive(false);
        }
        else if (GlassesValue == 3 && GlassesPaths.greenFound == false){
            currentGlassesText.text = "You do not have green glasses";
            redimage.SetActive(false);
            greenimage.SetActive(false);
            blueimage.SetActive(false);
        }

        if (GlassesValue == 4 && GlassesPaths.blueFound == true)
        {
            currentGlassesText.text = "You are wearing blue glasses";
            redimage.SetActive(false);
            greenimage.SetActive(false);
            blueimage.SetActive(true);
        }
        else if (GlassesValue == 4 && GlassesPaths.blueFound == false){
            currentGlassesText.text = "You do not have blue glasses";
            redimage.SetActive(false);
            greenimage.SetActive(false);
            blueimage.SetActive(false);
        }


    }
}

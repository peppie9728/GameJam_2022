using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;

    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void exitToMainMenu ()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }
}

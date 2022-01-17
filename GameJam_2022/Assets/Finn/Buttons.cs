using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
        

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void ReturnMenu()
    {
        Debug.Log("returnmenu");
        SceneManager.LoadScene(0);
    }

    public void settingsMenu ()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
}

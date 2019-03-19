using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject blurryPanel;
    public bool creditsActive = false;

    public void PlayGame()
    {
        SceneManager.LoadScene("Cut_Scene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void ShowCredits()
    {
        if (!creditsActive)
        {
            creditsPanel.SetActive(true);
            blurryPanel.SetActive(true);
            creditsActive = true;
        }
        else
        {
            creditsPanel.SetActive(false);
            blurryPanel.SetActive(false);
            creditsActive = false;
        }
    }
}

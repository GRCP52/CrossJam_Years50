using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{

    public Transform spot;
    public GameObject thePlayer;
    public GameObject emailPanel;

    public bool playerStopped = false;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "stopSpot")
        {
            emailPanel.SetActive(true);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Level_Selector");
    }

}

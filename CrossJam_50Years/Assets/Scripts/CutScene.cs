using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public Animator stopAnim;

    public Transform spot;
    public GameObject thePlayer;
    public GameObject blurryPanel;
    public GameObject emailPanel;

    public bool playerStopped;

    private void Start()
    {
        playerStopped = false;
        stopAnim = GetComponent<Animator>();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "stopSpot")
        {
            stopAnim.SetBool("Stop", true);
            blurryPanel.SetActive(true);
            emailPanel.SetActive(true);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Level_Selector");
    }

}

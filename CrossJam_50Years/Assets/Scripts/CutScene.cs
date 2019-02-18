using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public Animator stopAnim;

    public Transform spot;
    public GameObject thePlayer;
    public GameObject emailPanel;
    public GameObject emailPanel2;

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
            //emailPanel.SetActive(true);
            emailPanel2.SetActive(true);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Level_Selector");
    }

}

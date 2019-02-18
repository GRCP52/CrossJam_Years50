﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    Animator stopAnim;

    public Transform spot;
    public GameObject thePlayer;
    public GameObject emailPanel;

    public bool playerStopped = false;

    private void Start()
    {
        stopAnim = GetComponent<Animator>(); 
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "stopSpot")
        {
            stopAnim.SetBool(stop, true);
            emailPanel.SetActive(true);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Level_Selector");
    }

}

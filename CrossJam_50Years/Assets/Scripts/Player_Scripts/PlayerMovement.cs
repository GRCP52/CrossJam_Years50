﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Animator anim;

    private PlayerController2D controller;

    public float horizontalMove = 1f;

    public bool jump;

    void Start()
    {
        controller = GetComponent<PlayerController2D>();
        anim = GetComponent<Animator>();
        jump = false;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        //jump = false;
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "End")
            SceneManager.LoadScene("Level_Selector");
    }

    public void PlayerJump ()
    {
        anim.SetTrigger("Jump");
        jump = true;
        jump = false;
        Debug.Log("Jump: " + jump);
    }

}

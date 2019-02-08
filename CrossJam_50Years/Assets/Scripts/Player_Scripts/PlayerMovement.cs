using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    Animator anim;

    private PlayerController2D controller;

    public float horizontalMove = 1f;

    public bool jump = false;


    private void Awake()
    {
        controller = GetComponent<PlayerController2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Jump");
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}

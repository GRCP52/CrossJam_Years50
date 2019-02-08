using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    Animator anim;

    public PlayerController2D controller;

    public float horizontalMove = 1f;

    public float runSpeed = 40f;

    public bool jump = false;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        horizontalMove = runSpeed;

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

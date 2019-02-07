using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementJon : MonoBehaviour
{

    public PlayerController2D controller;

    public float horizontalMove = 0f;

    public float runSpeed = 40f;

    public bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown("w") | Input.GetKeyDown("space"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{

    public Transform spot;
    public Rigidbody2D thePlayer;

    public bool playerStoped = false;

    private void Update()
    {
        StopMoving();
    }

    void StopMoving ()
    {
        if (spot.position.x <= thePlayer.position.x)
        {
            thePlayer.GetComponent<PlayerMovement>().runSpeed = 0;
            playerStoped = true;
        }
    }

}

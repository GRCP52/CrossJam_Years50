using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{

    public Transform spot;
    public Rigidbody2D thePlayer;

    private void Update()
    {
        stopMoving();
    }

    void stopMoving ()
    {
        if (spot.position.x <= thePlayer.position.x)
            thePlayer.GetComponent<PlayerMovement>().runSpeed = 0;
    }

}

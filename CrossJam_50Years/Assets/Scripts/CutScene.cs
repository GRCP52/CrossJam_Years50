using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{

    public Transform spot;
    public GameObject thePlayer;
    public GameObject emailPanel;

    public float cutSceneRunSpeed = 0;

    public bool playerStopped = false;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "stopSpot")
        {
            StopMoving();
        }
    }

    void StopMoving ()
    {
        thePlayer.GetComponent<PlayerMovement>().runSpeed = cutSceneRunSpeed;
        playerStopped = true;
        emailPanel.SetActive(true);
    }

}

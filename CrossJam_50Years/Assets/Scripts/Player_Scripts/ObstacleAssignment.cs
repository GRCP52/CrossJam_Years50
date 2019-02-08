using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAssignment : MonoBehaviour
{
    public GameObject thePlayer;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Assignment_Obstacle"))
        {
            Destroy(col.gameObject);
            thePlayer.GetComponent<PlayerController2D>().realVelocity *= 0.90f;
        }
    }
}

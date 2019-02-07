using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Script : MonoBehaviour {

    public GameObject thePlayer;

    public float runSpeed;
    public float depressionDuration = 5000f;
    public  float depressionDurationLeft;

    public bool failed;

    private void Update()
    {
        GetComponent<PlayerMovement>().runSpeed = runSpeed;

        DepressionUpdate();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("F_Obstacle"))
        {
            Destroy(col.gameObject);
            StartDepression();
        }
    }

    private void DepressionUpdate ()
    {
        //if (failed)
        //    StartDepression();

        if (runSpeed == 0 && depressionDurationLeft <= 0)
            StopDepression();

        if (depressionDurationLeft > 0)
            depressionDurationLeft -= Time.deltaTime;
    }

    private void StartDepression ()
    {
        runSpeed = 0f;
        depressionDurationLeft = depressionDuration;
    }

    private void StopDepression ()
    {
        runSpeed = 40f;
        failed = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavyAssignment : MonoBehaviour {

    public float frequency;
    public float magnitude;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}

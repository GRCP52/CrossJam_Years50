using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator_Script : MonoBehaviour {

    public void SixthFloor()
    {
        SceneManager.LoadScene("Floor6");
    }

    public void SeventhFloor()
    {
        SceneManager.LoadScene("Floor7");
    }
}

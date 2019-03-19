using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtons : MonoBehaviour {

    public GameObject elevatorPanels;
    
    public void LevelSelector()
    {
        elevatorPanels.SetActive(true);
    }
}

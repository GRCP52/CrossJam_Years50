using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaging : MonoBehaviour {

    public GameObject fObstacle;
    public Transform mainCamera;

    private float fObstacleCooldown;
    private float fObstacleTimer;
    private float fObstacleY;

    private float spawningSpot;
    public Transform destroySpot;

    private void Awake()
    {
        fObstacleCooldown = Random.Range(2f, 6f);
        fObstacleTimer = Random.Range(2f, 4f);
        fObstacleY = Random.Range(-1.9f, 1.2f);
    }

    private void Update()
    {
        spawningSpot = mainCamera.position.x + 12.5f;

        SpawningF();
    }

    private void SpawningF()
    {

        if(Time.time >= fObstacleTimer)
        {
            GameObject fail = (GameObject)Instantiate(fObstacle, new Vector3(spawningSpot, fObstacleY, 0), Quaternion.identity);
            fail.GetComponent<F_Controller>().spot = destroySpot;

            fObstacleCooldown = Random.Range(3f, 6f);
            fObstacleY = Random.Range(-1.9f, 1.2f);
            fObstacleTimer = Time.time + fObstacleCooldown;
        }

    }
}

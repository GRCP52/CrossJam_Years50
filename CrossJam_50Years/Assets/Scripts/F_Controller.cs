using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class F_Controller : MonoBehaviour {

    public float speed;

    public Transform spot;

    private void Start()
    {
        StartCoroutine("Moving");
    }

    private void LateUpdate()
    {
        if (transform.position.x == spot.position.x)
            Destroy(gameObject);
    }

    IEnumerator Moving() {
        while (transform.position.x != spot.position.x && transform.position.y != spot.position.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(spot.position.x, transform.position.y), speed);

            yield return null;
        }
    }
}
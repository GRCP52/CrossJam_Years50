using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Update()
    {

        transform.position = new Vector3((target.position.x + offset.x), (0 + offset.y), (target.position.z + offset.z));

    }
}

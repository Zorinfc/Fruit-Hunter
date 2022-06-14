using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0,0,-10);
    }
}

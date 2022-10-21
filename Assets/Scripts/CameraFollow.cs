using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 camPos;

    // Update is called once per frame
    void Update()
    {
        camPos.x = 9f; camPos.y = 10f; camPos.z = 0f;
        transform.position = player.position + camPos;
    }
}

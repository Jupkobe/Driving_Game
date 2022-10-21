using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    void Start()
    {
        rb.AddForce(speed, 0, 0, ForceMode.VelocityChange);
    }
}

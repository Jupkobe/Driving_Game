using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    private int lane = 1;//0,1,2 left, mid, right
    public float laneDistance = 3.2f;
    void Update()
    {
        Vector3 targetPos = transform.position.x * transform.right + transform.position.y * transform.up;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lane < 2)
                lane++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (lane > 0) 
                lane--;
        }        

        if (lane == 0)
        {
            targetPos += Vector3.back * laneDistance;
        }
        else if (lane == 2)
        {
            targetPos += Vector3.forward * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPos, 800 * Time.deltaTime);
    }
}
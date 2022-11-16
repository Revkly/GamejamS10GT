using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraFollow : MonoBehaviour
{
    public Transform targetKamera;
    public float smoothspeed;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -1f, 46f),
            Mathf.Clamp(transform.position.y, -2f, 2f),
            transform.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 desiredPos = targetKamera.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothspeed);

        transform.position = smoothedPos;
        transform.LookAt(targetKamera);
    }
}

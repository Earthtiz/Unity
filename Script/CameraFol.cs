using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFol : MonoBehaviour
{
    public Transform player;
    private Vector3 cameraOffset;

    [Range(0.00f, 1.0f)]
    public float smoothness = 0.5f;

    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }


    void Update()
    {
        Vector3 newPos = player.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothness);
    }
}


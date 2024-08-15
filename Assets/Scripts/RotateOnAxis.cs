using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnAxis : MonoBehaviour
{
    public float orbitTimeInEarthHours = 1.0f;
    public bool clockWise = false;

    private float timeDeltaPerGameSecondsInEarthHours = 1;

    private float rotationSpeedPerGameSecond;

    void Start()
    {
        rotationSpeedPerGameSecond = 360 / orbitTimeInEarthHours;
    }

    void Update()
    {

        float angleToRotate = rotationSpeedPerGameSecond * timeDeltaPerGameSecondsInEarthHours  * Time.deltaTime;

        transform.Rotate(Vector3.forward, (clockWise ? 1 : -1) * angleToRotate);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    [SerializeField] public Transform parentBody;
    public float orbitTimeInEarthDays;
    public bool clockWise = false;

    private float timeDeltaPerSecondsInHours = 1;
    private float rotationSpeedPerGameSecond;

    void Start()
    {
        rotationSpeedPerGameSecond = 360 / (orbitTimeInEarthDays * 24);
    }

    void Update()
    {
        if (parentBody == null)
        {
            Debug.LogError("Center object not assigned. Please assign a GameObject for rotation center. Object name : " + name);
            return;
        }

        float angleToRotate = rotationSpeedPerGameSecond * timeDeltaPerSecondsInHours * Time.deltaTime;
        Debug.Log(this.name + " to " + this.parentBody.name + " : " + (parentBody.position - transform.position).magnitude);

        transform.RotateAround(Vector3.zero, Vector3.up, (clockWise ? 1 : -1) * angleToRotate);
    }

}

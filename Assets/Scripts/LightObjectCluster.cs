using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObjectCluster : MonoBehaviour
{
    [SerializeField] public Transform target;

    void Start()
    {

    }

    void Update()
    {
        this.transform.forward = target.position.normalized;
    }
}

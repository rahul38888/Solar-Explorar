using System;
using System.Collections;
using UnityEngine;


public class StellerObjectConfig
{
    public String eName;
    public Boolean isPlanet;
    public float semimajorAxis;
    public float meanRadius;
    public float sideralOrbit;
    public float mass;
    public OrbitType orbitType;
    public String orbits;
    public float sideralRotation;
    public float inclination;
    public float geomAlbido;

    public GameObject selfGameObject;
    public GameObject orbitsgameObject;
}

public enum OrbitType
{
    Primary,
    Secondary
}
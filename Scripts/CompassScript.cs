﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;
using UnityEngine.UI;

public class CompassScript : MonoBehaviour
{

    public RawImage compass;
    public Transform player;

    void Update()
    {

        compass.uvRect = new Rect(player.localEulerAngles.y / 360f, 0, 1, 1);

    }

}/*
public class CompassHandler : MonoBehaviour
{
    public float numberOfPixelsNorthToNorth;
    public GameObject target;
    Vector3 startPosition;
    float rationAngleToPixel;

    void Start()
    {
        startPosition = transform.position;
        rationAngleToPixel = numberOfPixelsNorthToNorth / 360f;
    }

    void Update()
    {
        Vector3 perp = Vector3.Cross(Vector3.forward, target.transform.forward);
        float dir = Vector3.Dot(perp, Vector3.up);
        transform.position = startPosition + (new Vector3(Vector3.Angle(target.transform.forward, Vector3.forward) * Mathf.Sign(dir) * rationAngleToPixel, 0, 0));
        Vector3.Angle(new Vector3(target.transform.forward.x, 0f, target.transform.forward.z), Vector3.forward)
    }
}*/




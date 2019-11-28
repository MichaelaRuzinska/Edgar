﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum_movement : MonoBehaviour
{
     public float delta = 1.5f;  // Amount to move left and right from the start point
     public float speed = 1.0f;
     private Vector3 startPos;

     void Start()
     {
         startPos = transform.position;
     }

    void FixedUpdate()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        //float zDegrees = Time.deltaTime / 60 * 360 * speed;
       // transform.RotateAround(transform.position, transform.forward, zDegrees);
        transform.position = v;
    }
}

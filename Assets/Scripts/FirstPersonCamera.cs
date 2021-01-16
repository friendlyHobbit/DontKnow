﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;
    

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update ()
    {
        KeyboardMovement();
    }

    void LateUpdate ()
    {
        //MouseAiming();
    }
    
    void MouseAiming ()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
    
        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
    
        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }
    
    void KeyboardMovement ()
    {
        Vector3 dir = new Vector3(0, 0, 0);
    
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
    
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }
}

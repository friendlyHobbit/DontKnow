using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        print("vertical" + Input.GetAxis("Vertical"));
        //print("horizontal" + Input.GetAxis("Horizontal"));
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBall : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(30.0f, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-30.0f, 0.0f, 0.0f));
        }
    }
}

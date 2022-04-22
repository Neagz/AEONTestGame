using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float rotSpeed = 5f;
    public float moveSpeed = 10f;
    private float minimalHeight = -15f;
    private float finish = 175f;

    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal") * rotSpeed;
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.rotation *= Quaternion.Euler(0f, rotation, 0f);
        rb.MovePosition(transform.position + transform.forward * move);
        
        CheckFall();
        

    }
    
    void CheckFall()
    {
        if (transform.position.y < minimalHeight)
        {
            SceneManager.LoadScene("MainMenuLose");
            Destroy(gameObject);
        }

        if (transform.position.z > finish)
        {
            SceneManager.LoadScene("MainMenuWin");
            Destroy(gameObject);
        }
    }

}



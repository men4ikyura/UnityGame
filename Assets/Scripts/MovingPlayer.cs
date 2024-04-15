using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Moving : MonoBehaviour
{
    private int changeMoveSide;
    private int changeMoveForward;
    public float speed;
    public static  Vector3 initialPosition; 

    private void Start()
    {
        
        initialPosition = transform.position;
    }
   
    void Update()
    {
        ManageMoving();
        Time.timeScale = 1f;
    }

    public void ManageMoving()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            changeMoveSide = -1;
            changeMoveForward = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            changeMoveSide = 1;
            changeMoveForward = 0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            changeMoveSide = 0;
            changeMoveForward = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            changeMoveSide = 0;
            changeMoveForward = -1;
        }

        transform.position = new Vector3(changeMoveSide * speed + transform.position.x, transform.position.y,
            changeMoveForward * speed + transform.position.z);
    }
}

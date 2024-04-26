using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Moving : MonoBehaviour
{
    public float speed;
    public static  Vector3 initialPosition; 

    private void Start() => initialPosition = transform.position;
   
    void Update()
    {
        var moveHorizontal = 0f;
        var moveVertical = 0f;

        if (Input.GetKey(KeyCode.A))
            moveHorizontal = -1f;
        else if (Input.GetKey(KeyCode.D))
            moveHorizontal = 1f;
        if (Input.GetKey(KeyCode.W))
            moveVertical = 1f;
        else if (Input.GetKey(KeyCode.S))
            moveVertical = -1f;

        var movement = new Vector3(moveHorizontal * speed * Time.timeScale, 0f, moveVertical * speed * Time.timeScale);
        transform.position += movement;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMoving : MonoBehaviour
{
    public float changer;
    public float speed = 0.008f;
    public float extremeCoordinate = 10f;
   
    void Update()
    {
            transform.position += new Vector3(speed * changer * Time.timeScale, 0, 0);
            DeleteCube();
    }

    void DeleteCube()
    {
        if (Math.Abs(transform.position.x) > extremeCoordinate)
            Destroy(gameObject);
    }
}

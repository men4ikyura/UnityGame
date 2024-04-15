using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMoving : MonoBehaviour
{
    public float changer;
    public float speed = 0.008f;
   
    void Update()
    {
        transform.position += new Vector3( speed * changer, 0, 0);
    }
}

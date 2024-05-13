using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision2 : MonoBehaviour
{
    public ControllText controller;
    private Rigidbody rb;
    // private Vector3 minScale = new Vector3(0.2f, 0.2f, 0.2f);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb);
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            controller.ControllScore();
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Triger"))
            transform.localScale += new Vector3(0.1f,0.1f,0.1f);

        if (collision.gameObject.CompareTag("NotTriger"))
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

        if (collision.gameObject.CompareTag("Accelerator"))
            rb.AddForce(transform.forward * 500f, ForceMode.Acceleration);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision: MonoBehaviour
{
    public ControllText controller;
    private bool IsProtected = false;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") && !IsProtected)
        {
            SceneManager.LoadScene(1);
            controller.ControllScore();
        }

       
        if (collision.gameObject.CompareTag("Accelerator") && !IsProtected)
        {
            IsProtected = true;
            StartCoroutine(EnableColliderAfterDelay(5.0f));
        }

        IEnumerator EnableColliderAfterDelay( float delay)
        {
            yield return new WaitForSeconds(delay);
            IsProtected = false;
        }
    }
}

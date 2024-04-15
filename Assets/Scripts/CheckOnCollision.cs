using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision: MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            transform.position = Moving.initialPosition;
            Time.timeScale = 0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

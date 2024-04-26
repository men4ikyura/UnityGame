using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision: MonoBehaviour
{
    public ViewScore scoreView;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            transform.position = Moving.initialPosition;
            scoreView.OnClickReduceScore();
            if (ModelScore.score == 0)
            {
                ModelScore.score = 5;
                SceneManager.LoadScene(1);
            }
        }
    }
}

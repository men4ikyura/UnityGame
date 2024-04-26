using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public SceneController controller;
    public GameObject panelPause;
    public GameObject panelExit;
    
    public void OnClick()
    {
        if (controller.IsPaused())
        {
            panelPause.SetActive(false);
            panelExit.SetActive(false);
            controller.ResumeGame();
        }
        else
        {
            panelPause.SetActive(true);
            controller.PauseGame();
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("мы здесь");
            OnClick();
        }
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public GameObject player;
    
    void Update()
    {
        if (player.transform.position.z < 20f && player.transform.position.z > 19f)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision : MonoBehaviour
{
    public ControllEffect controllerEffect;
    public ControllText controllerText;
    public bool isProtected = false;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") && !isProtected)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            controllerText.ControllScore();
        }

        if (collision.gameObject.CompareTag("Accelerator"))
            controllerEffect.ControllEfect(); 
    }
}


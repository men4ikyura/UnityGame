using UnityEngine;
public class PlayerMoving : MonoBehaviour
{

    public float speed;
    public float accelerator = 1;
    void Update()
    {
        var moveHorizontal = 0f;
        
        if (Input.GetKey(KeyCode.A))
            moveHorizontal = -1f;
        else if (Input.GetKey(KeyCode.D))
            moveHorizontal = 1f;
            
        var movement = new Vector3(moveHorizontal * 0.015f * Time.timeScale, 0f, speed * Time.timeScale);
        transform.position += movement;
    }
}
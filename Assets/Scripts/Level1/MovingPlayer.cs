using UnityEngine;

public class MovingPlayer: MonoBehaviour
{
    public float speed;
    

    void Update()
    {
        var moveHorizontal = 0f;
        var moveVertical = 0f;

        if (Input.GetKey(KeyCode.A))
            moveHorizontal = -1f;
        else if (Input.GetKey(KeyCode.D))
            moveHorizontal = 1f;
        if (Input.GetKey(KeyCode.W))
            moveVertical = 1f;
        else if (Input.GetKey(KeyCode.S))
            moveVertical = -1f;

        var movement = new Vector3(moveHorizontal * speed * Time.timeScale, 0f, moveVertical * speed * Time.timeScale);
        transform.position += movement;
    }
}
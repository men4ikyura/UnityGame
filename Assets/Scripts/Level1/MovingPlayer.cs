using UnityEngine;

public class MovingPlayer: MonoBehaviour
{
    public float speed;
    public float accelerator = 1;

    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, moveVertical * speed * Time.deltaTime) ;
        transform.position += movement;
    }
}
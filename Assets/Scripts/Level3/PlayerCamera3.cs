using UnityEngine;

public class FollowObject3 : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 10f, target.position.z - 5f);
    }
}
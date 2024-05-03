using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 20f, target.position.z - 5f);
    }
}


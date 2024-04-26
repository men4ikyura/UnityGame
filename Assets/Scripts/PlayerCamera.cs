using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 10f, target.position.z - 10f);
    }
}


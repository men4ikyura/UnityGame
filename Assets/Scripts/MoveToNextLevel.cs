using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public GameObject player;
    public GameObject plane;
    private float _limitCoordinate;
    
    public float LimitCoordinate {
        get => _limitCoordinate;
        set => _limitCoordinate = value;
    }
    
    void Start()
    {
        LimitCoordinate = plane.transform.localScale.z / 2 * 10;
    }
    
    void Update()
    {
       
        if (player.transform.position.z < LimitCoordinate && player.transform.position.z > LimitCoordinate - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

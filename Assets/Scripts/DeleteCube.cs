using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace DefaultNamespace
{
    public class DeleteCube : MonoBehaviour
    {
        public float coordinate = 10f;
        
        void Update()
        {
            if (Math.Abs(transform.position.x) > coordinate)
                Destroy(gameObject);
        }
    }
}
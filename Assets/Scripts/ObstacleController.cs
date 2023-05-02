using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        if (transform.position.z <= -35) // cisimmler belli bir z konumunu geçtikten sonra yok olsunlar 
        {
            Destroy(gameObject);
        }
    }
}

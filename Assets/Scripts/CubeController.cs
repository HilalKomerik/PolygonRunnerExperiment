using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        if (transform.position.z <= -30.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 30.0f);
            //Binalarýmýzý konumuna göre arkaya gönderiziyoruz.
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float _xSpeed; 
    [SerializeField] private float _xLimit; 
    
    void Update()
    {
        float _horizontal = 0;
        float _newX = 0;
        if (Input.GetMouseButton(0))
        {
            _horizontal = Input.GetAxisRaw("Mouse X");
        }

        
        if (_horizontal > 0)
        {
            UpdateRotation(-20);
        }
        else if (_horizontal < 0)
        {
            UpdateRotation(20);
        }
        else
        {
            UpdateRotation(0);
        }

        _newX = transform.position.x + _horizontal * _xSpeed * Time.deltaTime;
        _newX = Mathf.Clamp(_newX, -_xLimit, _xLimit); // Alandan çýkmasýný engelliyorum.

        transform.position = new Vector3(_newX, transform.position.y, transform.position.z);
    }

    private void UpdateRotation(float _value)
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, _value), 5 * Time.deltaTime);
        // iki nokta arasýný otomatik doldurur(Yavaþ yavaþ geçiþ olmasýný saðlayacak)
    }
}

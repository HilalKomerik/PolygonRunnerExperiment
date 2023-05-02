using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _planeTransform;
    private Vector3 _offset;
    [SerializeField] [Range(0,2)] private float _lerpTime;

    void Start()
    {
        _offset = transform.position - _planeTransform.position;
    }

    void LateUpdate()
    {
        Vector3 _newPos = Vector3.Lerp(transform.position, _planeTransform.position + _offset, _lerpTime * Time.deltaTime);
        transform.position = _newPos;
    }
}

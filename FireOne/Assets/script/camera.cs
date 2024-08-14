using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 _curretVelocity = Vector3.zero;
    
    void Awake()
    {
        _offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        Vector3 targetPosition = transform.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _curretVelocity, smoothTime) ;
    }
}

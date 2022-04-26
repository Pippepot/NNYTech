using System;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    
    public float smoothSpeed = 2f;

    void Update()
    {
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}

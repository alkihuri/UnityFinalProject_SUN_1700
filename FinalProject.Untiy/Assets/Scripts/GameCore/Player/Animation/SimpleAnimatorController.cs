using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimatorController : MonoBehaviour
{
    [SerializeField] Animator _animatror;
    float currentSpeed;
    Vector3 lastPosition;
    float delta;

    // Update is called once per frame
    void Update()
    {
        delta = (transform.position - lastPosition).magnitude;

        currentSpeed = delta > 0 ? 1 : 0;
        currentSpeed = Mathf.Clamp01(currentSpeed);
        _animatror.SetFloat("Speed", currentSpeed);  
        lastPosition = transform.position;

    }
}

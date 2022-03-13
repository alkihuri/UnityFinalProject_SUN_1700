using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimatorController : MonoBehaviour
{
    [SerializeField] Animator _animatror;
    [SerializeField] CharacterController _character;
    float currentSpeed;
     

    // Update is called once per frame
    void Update()
    {
        currentSpeed = _character.velocity.magnitude;
        currentSpeed = Mathf.Clamp01(currentSpeed);
        _animatror.SetFloat("Speed", currentSpeed);
    }
}

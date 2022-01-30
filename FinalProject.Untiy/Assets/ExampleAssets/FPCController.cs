using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public Camera mainCamera; 
    [Range(1, 10)] public float walkingSpeed = 1  ;
    [Range(1, 10)] public float turnSpeed = 1;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalValue = Input.GetAxis("Vertical");
        float horizontalValue = Input.GetAxis("Horizontal");

        Vector3 forwardDirection = verticalValue * transform.forward * walkingSpeed;
        Vector3 sideDirection = horizontalValue * transform.right * walkingSpeed;
        Vector3 totalDirection = forwardDirection + sideDirection;
        characterController.SimpleMove(totalDirection);
        float rotateValue = Input.GetAxis("Mouse X") * turnSpeed;
        float cameraRotateValue = Input.GetAxis("Mouse Y") * turnSpeed; 
        transform.Rotate(0, rotateValue, 0);
        mainCamera.transform.Rotate(-cameraRotateValue, 0, 0);
    }
}

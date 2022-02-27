using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MovementScript : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private float turner;
    private float looker;
    [SerializeField,Range(1,100)] float sensitivity;
    [SerializeField] GameObject _camera;
    private float yCameraAngle;
    private float xCameraAngle;
    private float _yAngleRestriction = 45;
    private float speedBoost = 2;
    public GameObject showEscapePanel;

                
// Update is called once per frame
    void FixedUpdate()
    {
        // Check if player is mine
        if (GetComponent<PhotonView>())
            if (!GetComponent<PhotonView>().IsMine)
                return;
        DoMovement(); 
    }

    private void DoMovement()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        if (!controller.GetComponent<PhotonView>().IsMine)
            return;

        // is the controller on the ground?
        if (controller.isGrounded)
        {
            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDirection *= speed * speedBoost;
            }
            else
                moveDirection *= speed;
            //Jumping
            if (Input.GetButton("Jump"))
            {
                AudioManager.Instance.PlayJump();
                moveDirection.y = jumpSpeed;
            }

        }
        turner = Input.GetAxis("Mouse X") * sensitivity;
        looker = -Input.GetAxis("Mouse Y") * sensitivity;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showEscapePanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showEscapePanel.SetActive(false);
        }

        if (turner != 0)
        {
            //Code for action on mouse moving right
            transform.eulerAngles += new Vector3(0, turner, 0);
        }
        YAngleRestrictionFeature(looker);
        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);


        CursorModeSettings();
    }

    private void YAngleRestrictionFeature(float mouseY)
    {
        yCameraAngle += mouseY;
        xCameraAngle = transform.rotation.eulerAngles.y;
        var clampedYCameraAngle = Mathf.Clamp(yCameraAngle, -_yAngleRestriction, _yAngleRestriction);
        if (yCameraAngle > _yAngleRestriction)
            yCameraAngle = _yAngleRestriction;
        if (yCameraAngle < -_yAngleRestriction)
            yCameraAngle = -_yAngleRestriction;
        _camera.transform.rotation = Quaternion.Euler(clampedYCameraAngle, xCameraAngle, 0);
    }

    private static void CursorModeSettings()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
    }
}


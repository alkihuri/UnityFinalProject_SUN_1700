using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.Linq;


public class CameraControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Camera> cameras = GameObject.FindObjectsOfType<Camera>().ToList();
        foreach(Camera screenCamera in cameras)
        {
            if(!screenCamera.GetComponentInParent<PhotonView>().IsMine)
            {
                screenCamera.enabled = false;
            }
        }

    } 
}

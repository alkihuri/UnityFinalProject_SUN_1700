using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    [SerializeField] GameObject _camera;
    Vector3 _shootDirection;
    Vector3 _originPoint;
    Vector3 _attentionPoint;
    // Start is called before the first frame update
    void Start()
    {
        /// camera innit
    }

    private void GetRaycastInputVectors()
    {
        _shootDirection = _camera.transform.forward;
        _originPoint = _camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetRaycastInputVectors();
        RaycastHit objectOnHitLine; 
        if(Physics.Raycast(_originPoint,_shootDirection,out objectOnHitLine))
        {
            _attentionPoint = objectOnHitLine.point;
        }
        
    }


    private void OnDrawGizmos()
    {
       // Gizmos.DrawSphere(_attentionPoint, 5);
    }
}

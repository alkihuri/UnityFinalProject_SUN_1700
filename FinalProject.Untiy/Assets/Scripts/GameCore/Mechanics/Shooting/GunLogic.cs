using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class Gun
{
    public Gun(string newName, float newDamage, float newRate, int newAmmo,float newRadius)
    {
        gunName = newName;
        damage = newDamage;
        rate = newRate;
        ammo = newAmmo;
        radius = newRadius;
    }

    public string gunName;
    public float damage;
    public float rate;
    public int ammo; 
    public float radius; 
}

public class GunLogic : MonoBehaviour  
{
    [SerializeField] GameObject _camera;
    Vector3 _shootDirection;
    Vector3 _originPoint;
    Vector3 _attentionPoint;
    [SerializeField] Gun _currentGun;
    private bool _canShoot;
    [SerializeField] FixedJoystick _attack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    
    private void GetRaycastInputVectors()
    {
        _shootDirection = _camera.transform.forward;
        _originPoint = _camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _canShoot = _attack.Horizontal > 0;
        GetRaycastInputVectors();
        RaycastHit objectOnHitLine; 
        if(Physics.Raycast(_originPoint,_shootDirection,out objectOnHitLine))
        {
            _attentionPoint = objectOnHitLine.point;
            if(objectOnHitLine.transform.gameObject.GetComponent<PlayerStats>())
            { 
                    if( _canShoot  )
                        Shoot(objectOnHitLine);
            }
        }
        
    }
     

    private void Shoot(RaycastHit objectOnHitLine)
    {
        PlayerStats enemy = objectOnHitLine.transform.gameObject.GetComponent<PlayerStats>();


        if (!objectOnHitLine.transform.gameObject.GetComponent<PhotonView>().IsMine)
            enemy.SyncHPChanges(-_currentGun.damage);

        AudioManager.Instance.PlayShoot();
        Debug.Log("Shoot!");
    }

     
 
}

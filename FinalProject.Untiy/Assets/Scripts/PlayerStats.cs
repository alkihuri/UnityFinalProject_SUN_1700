using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerStats : MonoBehaviourPunCallbacks
{
    public float healthPoints = 100; 


    [PunRPC]
    public void ChangeHP(float changeValue)
    {
        healthPoints += changeValue;
        healthPoints = Mathf.Clamp(healthPoints, 0, 100);
        if(healthPoints<=0)
        {
            SyncRespawn(); 
        }
    }

    [PunRPC]
    public void  Respawn()
    {
        healthPoints = 100;
        List<Transform> points = FindObjectOfType<CustomGameManager>()._spawnPoints;
        Vector3 pos = points[Random.Range(0, points.Count - 1)].position;
        transform.position = pos;
    }

    // Update is called once per frame
    public void SyncHPChanges(float changeValue)
    {
        GetComponent<PhotonView>().RPC("ChangeHP", RpcTarget.All, changeValue);
    }
    public void SyncRespawn()
    {
        GetComponent<PhotonView>().RPC("Respawn", RpcTarget.All);
    }

}

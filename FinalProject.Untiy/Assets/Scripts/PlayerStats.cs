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
            SyncHPChanges(100);
            List<Transform> points = FindObjectOfType<CustomGameManager>()._spawnPoints;
            Vector3 pos = points[Random.Range(0, points.Count - 1)].position;
            transform.SetPositionAndRotation(pos,Quaternion.identity); 
            Debug.Log(pos);
        }
    }

    // Update is called once per frame
    public void SyncHPChanges(float changeValue)
    {
        GetComponent<PhotonView>().RPC("ChangeHP", RpcTarget.All, changeValue);
    }

    private void Update()
    {
         
    }

}

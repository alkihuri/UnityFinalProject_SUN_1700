using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayersObjectHandler : MonoBehaviour
{

    [SerializeField] GameObject[] objectsToDestroy;
    // Start is called before the first frame update
    void Start()
    {
     if(!GetComponent<PhotonView>().IsMine)
    {
            foreach (GameObject todestroy in objectsToDestroy)
                Destroy(todestroy);
    }
    }
      
}

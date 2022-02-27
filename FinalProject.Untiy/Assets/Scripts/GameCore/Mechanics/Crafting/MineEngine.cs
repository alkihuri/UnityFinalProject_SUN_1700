using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Photon.Pun;

public class MineEngine : MonoBehaviour
{
    [SerializeField] List<ResourceItem> resourceList = new List<ResourceItem>();
    private void Start()
    {
        if (GetComponent<PhotonView>().IsMine)
            CreateInv();
    }

    private void CreateInv()
    {
        resourceList.Add(new ResourceItem(ResourceItem.Resource.metal));
        resourceList.Add(new ResourceItem(ResourceItem.Resource.stone));
        resourceList.Add(new ResourceItem(ResourceItem.Resource.sulfur));
        resourceList.Add(new ResourceItem(ResourceItem.Resource.wood));
    }
    [PunRPC]
    public void AddValueToResource(float value,  ResourceItem.Resource type)
    {
         
        resourceList.Where(r => r.item == type).Last().AddValue(value); 
        PlayerPrefs.SetFloat(type.ToString(), value);
         
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            AddValueToResource(10, ResourceItem.Resource.sulfur);
    }

    public void AddValueThroughPhotonEngine(float value, ResourceItem.Resource type)
    {
        object[] some = { value, type };
        GetComponent<PhotonView>().RPC("AddValueToResource", RpcTarget.All, some);
    }


    private void OnTriggerStay(Collider other)
    {
            ///if (other.gameObject.GetComponent<скрипт для зона крафтинга>)
    }
}

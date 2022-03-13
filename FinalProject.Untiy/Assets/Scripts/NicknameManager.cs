using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NicknameManager : MonoBehaviourPunCallbacks
{

    [SerializeField] InputField nickname;

    void Start()
    {
        PhotonNetwork.NickName = nickname.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

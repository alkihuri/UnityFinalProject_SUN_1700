using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NicknameManager : MonoBehaviourPunCallbacks
{

    [SerializeField] InputField nickname;

    public void SetNickname()
    {
        PhotonNetwork.NickName = nickname.text.ToString();
    } 
}

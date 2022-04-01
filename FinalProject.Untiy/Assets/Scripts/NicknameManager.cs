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
        var nick = nickname.text.ToString();
        nick = nick.Length > 0 ? nick : "Player" + Random.Range(1111, 9999); 
        PhotonNetwork.NickName = nick;
    } 
}

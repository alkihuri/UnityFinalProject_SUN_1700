using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;



public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);   
        PhotonNetwork.NickName = "MyName" + Random.Range(1000,9999);
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log(PhotonNetwork.NickName);
    }

    public override void OnConnectedToMaster()
    {
        if (PhotonNetwork.CountOfRooms > 0)
            PhotonNetwork.JoinRoom("Rust");
        else
            PhotonNetwork.CreateRoom("Rust");
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GameDemo");
    }
    public override void OnCreatedRoom()
    {
        PhotonNetwork.JoinRoom("Rust");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Num. of players : " +  PhotonNetwork.CountOfPlayers);
    }
}

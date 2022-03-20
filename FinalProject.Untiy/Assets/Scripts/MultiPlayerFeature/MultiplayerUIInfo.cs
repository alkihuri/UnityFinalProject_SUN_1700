using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class MultiplayerUIInfo : MonoBehaviour
{

    [SerializeField] TMPro.TextMeshProUGUI _text;
    [SerializeField] PhotonView _photon;
    [SerializeField] PlayerStats _playerStats;
    // Start is called before the first frame update
    void Update()
    {
        string hp = _playerStats.healthPoints.ToString("#.");
        _text.text = _photon.Owner.NickName + " [ " + hp + " ]";
    }   


}

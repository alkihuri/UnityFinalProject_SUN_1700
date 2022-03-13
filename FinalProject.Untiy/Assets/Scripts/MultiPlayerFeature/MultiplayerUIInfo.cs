using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class MultiplayerUIInfo : MonoBehaviour
{

    [SerializeField] TMPro.TextMeshProUGUI _text;
    [SerializeField] PhotonView _photon;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = _photon.Owner.NickName;
    }   


}

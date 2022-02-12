using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Photon.Pun;

public class CustomGameManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] public List<Transform> _spawnPoints;
    [SerializeField] Transform _rootOfSpawnPoints;
    void Start()
    {
        _spawnPoints = _rootOfSpawnPoints.GetComponentsInChildren<Transform>().ToList();
        _player = Resources.Load<GameObject>("Player");  
        Vector3 randomPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count - 1)].position;
        PhotonNetwork.Instantiate("Player",randomPosition, Quaternion.identity);
    }
     
}

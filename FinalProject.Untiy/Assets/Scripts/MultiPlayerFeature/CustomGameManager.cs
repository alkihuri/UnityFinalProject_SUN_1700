using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGameManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] List<Transform> _spawnPoints;
    void Start()
    {
        _player = Resources.Load<GameObject>("Player");  
        Vector3 randomPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count - 1)].position;
        var _playerOnScene = Instantiate(_player, randomPosition, Quaternion.identity);
    }
     
}

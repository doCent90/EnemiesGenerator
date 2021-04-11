using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private Transform[] _spawnGate;

    private void Start()
    {
        _spawnGate = new Transform[gameObject.GetComponentsInChildren<Transform>().Length];

        for (int i = 0; i < _spawnGate.Length; i++)
        {
            _spawnGate[i] = gameObject.GetComponentsInChildren<Transform>()[i];
        }

        StartCoroutine(Spawn(2));
    }

    private IEnumerator Spawn(float seconds)
    {
        var waitForSeconds = new WaitForSeconds(seconds);
        yield return waitForSeconds;

        Vector3 position = _spawnGate[Random.Range(0, _spawnGate.Length)].position;
        Instantiate(_enemy, position, Quaternion.identity);

        RepeatSpawn();
    }

    private void RepeatSpawn()
    {
        StartCoroutine(Spawn(2));
    }
}

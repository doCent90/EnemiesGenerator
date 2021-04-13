using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnGate;
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        StartCoroutine(Spawn(2));
    }

    private IEnumerator Spawn(float delay)
    {
        while (true)
        {
            var waitForSeconds = new WaitForSeconds(delay);
            yield return waitForSeconds;

            Vector3 position = _spawnGate[Random.Range(0, _spawnGate.Count)].position;
            Instantiate(_enemy, position, Quaternion.identity);
        }
    }
}

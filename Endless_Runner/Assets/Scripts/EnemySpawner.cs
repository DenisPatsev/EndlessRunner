using System.Collections;
using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private Enemy[] _enemies;
    [SerializeField] private SpawnPoint[] _spawners;

    private bool _isWorking;

    private void Start()
    {
        _isWorking = true;

        Initialize(_enemies);

        StartCoroutine(GenerateEnemy(1));
    }

    private IEnumerator GenerateEnemy(float seconds)
    {
        var wait = new WaitForSeconds(seconds);

        while (_isWorking)
        {
            int spawnerIndex = Random.Range(0, _spawners.Length);

            if (TryGetObject(out Enemy enemy))
            {
                for (int i = 0; i < _spawners.Length; i++)
                {
                    if (i == spawnerIndex)
                    {
                        SetEnemy(enemy, _spawners[i].transform.position);
                    }
                }
            }

            yield return wait;
        }
    }

    private void SetEnemy(Enemy enemy, Vector3 spawnPoint)
    {
        enemy.gameObject.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}

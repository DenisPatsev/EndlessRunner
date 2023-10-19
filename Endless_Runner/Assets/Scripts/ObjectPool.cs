using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private List<Enemy> _pool = new List<Enemy>();

    protected void Initialize(Enemy[] prefabs)
    {
        for (int i = 0; i < _capacity; i++)
        {
            int index = Random.Range(0, prefabs.Length);
            Enemy enemy = Instantiate(prefabs[index], _container.transform);
            enemy.gameObject.SetActive(false);

            _pool.Add(enemy);
        }
    }

    protected bool TryGetObject(out Enemy result)
    {
        result = _pool.First(p => p.gameObject.active == false);

        return result != null;
    }
}

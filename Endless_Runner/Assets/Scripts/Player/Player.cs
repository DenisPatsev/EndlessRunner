using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private UnityEvent _takeDamage;
    [SerializeField] private UnityEvent _death;

    public float Health => _health;

    private void Start()
    {
        _takeDamage.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            collision.gameObject.SetActive(false);
            TakeDamage(enemy.Damage);
            _takeDamage.Invoke();
        }
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0) 
        {
            Die();
        }
    }

    private void Die()
    {
        _death.Invoke();
    }
}

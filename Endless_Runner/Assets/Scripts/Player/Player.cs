using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    public UnityAction TakeHit;
    public UnityAction Death;

    public float Health => _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            collision.gameObject.SetActive(false);
            TakeDamage(enemy.Damage);
            TakeHit.Invoke();
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
        Death.Invoke();
    }
}

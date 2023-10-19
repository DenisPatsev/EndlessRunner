using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _damage;

    public float Damage => _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}

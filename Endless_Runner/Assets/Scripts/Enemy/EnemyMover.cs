using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += new Vector3(-1 * _speed * Time.deltaTime, 0);
    }
}

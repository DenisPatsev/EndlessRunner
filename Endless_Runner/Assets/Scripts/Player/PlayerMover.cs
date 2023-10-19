using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _borderline;
    private float _step;

    private void Start()
    {
        _borderline = 7;
        _step = 1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < _borderline)
        {
            transform.Translate(new Vector3(0, _step * _speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -_borderline)
        {
            transform.Translate(new Vector3(0, -_step * _speed * Time.deltaTime, 0));
        }
    }
}

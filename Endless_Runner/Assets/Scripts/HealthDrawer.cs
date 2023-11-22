using UnityEngine;
using UnityEngine.UI;

public class HealthDrawer : MonoBehaviour
{
    [SerializeField] private Slider _bar;
    [SerializeField] private Player _player;

    private void Start()
    {
        _bar.maxValue = _player.Health;
        DrawCurrentHealth();
    }

    private void OnEnable()
    {
        _player.TakeHit += DrawCurrentHealth;
    }

    private void OnDisable()
    {
        _player.TakeHit -= DrawCurrentHealth;
    }

    private void DrawCurrentHealth()
    {
        _bar.value = _player.Health;
    }
}

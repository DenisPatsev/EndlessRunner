using UnityEngine;
using UnityEngine.UI;

public class HealthDrawer : MonoBehaviour
{
    [SerializeField] private Slider _bar;
    [SerializeField] private Player _player;

    private void Start()
    {
        _bar.maxValue = _player.Health;
    }

    public void DrawCurrentHealth()
    {
        _bar.value = _player.Health;
    }
}

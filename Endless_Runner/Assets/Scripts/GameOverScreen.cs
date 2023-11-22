using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverGroup;

    private void Awake()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        _gameOverGroup.alpha = 0;
    }

    private void OnEnable()
    {
        _player.Death += ShowScreen;
    }

    private void OnDisable()
    {
        _player.Death -= ShowScreen;
    }

    private void ShowScreen()
    {
        _gameOverGroup.alpha = 1;
        Time.timeScale = 0;
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

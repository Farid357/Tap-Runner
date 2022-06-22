using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class EndGamePanel : MonoBehaviour
{
    [SerializeField] private Button _restart;

    private readonly GameState _gameState = new();

    private void Start()
    {
        _restart.onClick.AddListener(Restart);
    }

    private void Restart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        _gameState.SetPause(false);
    }
    public void Show()
    {
        gameObject.SetActive(true);
        _gameState.SetPause(true);
    }
}

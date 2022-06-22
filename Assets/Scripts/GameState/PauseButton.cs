using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public sealed class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    private Button _button;
    private readonly GameState _gameState = new();

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Pause);
    }

    private void Pause()
    {
        _panel.SetActive(true);
        _gameState.SetPause(true);
    }
}

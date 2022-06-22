using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public sealed class ContinueButton : MonoBehaviour
{
    [SerializeField] private EndGamePanel _panel;
    private Button _continue;
    private readonly GameState _gameState = new();

    private void Start()
    {
        _continue = GetComponent<Button>();
        _continue.onClick.AddListener(Continue);
    }

    private void Continue()
    {
        _panel.gameObject.SetActive(false);
        _gameState.SetPause(false);
    }
}
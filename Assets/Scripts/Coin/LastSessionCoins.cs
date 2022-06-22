using TMPro;
using UnityEngine;

public sealed class LastSessionCoins : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private readonly CoinsCollector _collector = new();

    private void Start()
    {
        _text.text = _collector.GetLastSessionCoins().ToString();
    }
}
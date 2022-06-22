using TMPro;
using UnityEngine;

public sealed class CoinsCollectorView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coins;
    [SerializeField] private TextMeshProUGUI _record;
    public CoinsCollector Collector { get; private set; } = new();

    private void OnEnable()
    {
        Collector.OnChanged += Display;
        Collector.OnRecieveNewRecord += DisplayRecord;
        Collector.UpdateBestRecord();
    }

    private void OnDestroy()
    {
        Collector.OnChanged -= Display;
        Collector.OnRecieveNewRecord -= DisplayRecord;
    }
    private void Display(int count) => _coins.text = count.ToString();

    private void DisplayRecord(int count) => _record.text = count.ToString();
}
using System;
using UnityEngine;

public sealed class CoinsCollector
{
    public event Action<int> OnRecieveNewRecord;
    public event Action<int> OnChanged;
    private int _bestRecord;
    private int _coinsCount;
    private const string BestKey = "CoinsBest";
    private const string Key = "Coins";

    public void UpdateBestRecord()
    {
        _bestRecord = PlayerPrefs.GetInt(BestKey);
        OnRecieveNewRecord.Invoke(_bestRecord);
    }
    public int GetLastSessionCoins() => PlayerPrefs.GetInt(Key);

    public void AddOne()
    {
        _coinsCount++;
        if (_bestRecord < _coinsCount)
        {
            _bestRecord = _coinsCount;
            PlayerPrefs.SetInt(BestKey, _bestRecord);
            OnRecieveNewRecord.Invoke(_bestRecord);
        }

        PlayerPrefs.SetInt(Key, _coinsCount);
        OnChanged.Invoke(_coinsCount);
    }
}

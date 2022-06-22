using UnityEngine;

public struct Grid
{
    private float _minPositionX;

    public float GetMinPositionX()
    {
        var minPosition = Screen.safeArea.min;
        _minPositionX = Camera.main.ScreenToWorldPoint(minPosition).x - 10f;
        return _minPositionX;
    }
}
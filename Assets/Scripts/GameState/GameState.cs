using UnityEngine;

public sealed class GameState
{
    public void SetPause(bool isPaused)
    {
        Time.timeScale = isPaused ? 0 : 1;
    }
}
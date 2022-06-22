using System.Collections.Generic;
using UnityEngine;

public sealed class EnemyPlatformMovement : Movement
{
    public List<EnemyCollision> EnemyCollisions => _enemyCollisions;
    [SerializeField] private List<EnemyCollision> _enemyCollisions = new();
}

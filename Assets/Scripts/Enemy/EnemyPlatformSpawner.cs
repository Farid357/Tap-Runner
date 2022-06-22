using System.Collections;
using UnityEngine;

public sealed class EnemyPlatformSpawner : MonoBehaviour
{
    [SerializeField] private EndGamePanel _endGamePanel;
    [SerializeField] private EnemyPlatformMovement[] _prefabs;
    [SerializeField] private float _delay = 0.4f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            const float offsetX = 40f;
            var prefab = GetRandomPrefab();
            var platform = Instantiate(prefab);
            var position = new Vector2(platform.transform.position.x + offsetX, platform.transform.position.y);
            platform.transform.position = position;
            platform.EnemyCollisions.ForEach(p => p.Init(_endGamePanel));
            yield return wait;
        }
    }

    private EnemyPlatformMovement GetRandomPrefab()
    {
        var randomIndex = Random.Range(0, _prefabs.Length);
        var randomPrefab = _prefabs[randomIndex];
        return randomPrefab;
    }
}

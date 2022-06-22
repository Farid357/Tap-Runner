using System.Collections;
using UnityEngine;

public sealed class CoinSpawner : MonoBehaviour
{
    [SerializeField] private CoinsCollectorView _collectorView;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private CoinCollision _prefab;
    [SerializeField] private float _delay = 0.4f;

    private void Start()
    {
        StartCoroutine(TrySpawn());
    }

    private IEnumerator TrySpawn()
    {
        var wait = new WaitForSeconds(_delay);
        while (true)
        {
            yield return wait;
            if (CanSpawn())
            {
                var coin = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity, _spawnPoint);
                coin.Init(_collectorView.Collector);
            }
        }
    }
    private bool CanSpawn()
    {
        var randomIndex = UnityEngine.Random.Range(0, 4);

        if (randomIndex == 2)
        {
            return true;
        }
        return false;
    }
}

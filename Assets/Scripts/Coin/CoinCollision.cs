using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public sealed class CoinCollision : MonoBehaviour
{
    private CoinsCollector _collector;

    public void Init(CoinsCollector collector)
    {
        _collector = collector;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMovement player))
        {
            _collector.AddOne();
            Destroy(gameObject);
        }
    }
}

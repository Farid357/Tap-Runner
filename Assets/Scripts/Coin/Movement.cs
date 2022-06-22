using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    private readonly Grid _grid = new();

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        TryDestroy();
    }

    private void TryDestroy()
    {
        if (transform.position.x <= _grid.GetMinPositionX())
        {
            Destroy(gameObject);
        }
    }
}

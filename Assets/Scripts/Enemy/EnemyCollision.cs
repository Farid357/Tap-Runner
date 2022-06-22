using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private EndGamePanel _endGamePanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMovement player))
        {
            Destroy(player);
            _endGamePanel.Show();
        }
    }

    public void Init(EndGamePanel endGamePanel)
    {
        _endGamePanel = endGamePanel;
    }
}

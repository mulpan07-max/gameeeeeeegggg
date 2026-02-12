using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Обращаемся к ScoreManager и добавляем очки
            ScoreManager.instance.AddScore(points);

            // Удаляем предмет со сцены
            Destroy(gameObject);
        }
    }
}
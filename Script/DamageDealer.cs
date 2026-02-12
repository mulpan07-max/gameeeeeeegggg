using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Находим HealthManager на сцене
            HealthManager hm = Object.FindFirstObjectByType<HealthManager>();

            if (hm != null)
            {
                hm.TakeDamage(damageAmount);
            }
        }
    }
}
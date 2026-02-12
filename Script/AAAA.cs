using UnityEngine;

public class AAA : MonoBehaviour
{
    public float speed = 10f;
    public float jumpPower = 12f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Убираем вращение, чтобы он не падал
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Движение влево-вправо
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        // ПРЫЖОК: Просто нажали пробел — он летит вверх. Без проверок земли.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
    }
}
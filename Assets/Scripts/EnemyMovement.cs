using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public Transform pointA; // Точка A
    public Transform pointB; // Точка B
    public float speed = 2f; // Швидкість ворога

    private Vector3 targetPosition; // Поточна цільова позиція (А або Б)

    void Start()
    {
        targetPosition = pointB.position; // Спочатку ворог рухається до точки B
    }

    void Update()
    {
        // Переміщуємо ворога до цільової точки
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Коли ворог досягає цільової точки, змінюємо напрямок
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Якщо поточна цільова точка - це B, змінюємо на A і навпаки
            targetPosition = (targetPosition == pointA.position) ? pointB.position : pointA.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}

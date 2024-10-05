using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public float speed = 8f; // Швидкість руху гравця
        public Camera mainCamera;
        public Vector3 cameraOffset;
        public float jumpForce = 3f;

        private bool isGrounded; // Чи гравець на землі

        public Transform groundCheck; // Точка для перевірки, чи на землі гравець
        public float groundCheckRadius = 0.2f; // Радіус перевірки землі
        public LayerMask groundLayer; // Шар, що відповідає за землю

        Rigidbody2D rb; // Посилання на компонент Rigidbody гравця

        void Start()
        {
            rb = GetComponent<Rigidbody2D>(); // Отримати посилання на компонент Rigidbody

            if (mainCamera == null)
            {
                mainCamera = Camera.main; // Якщо камера не була призначена, знайти основну камеру
            }

            // Встановити початкове зміщення камери відносно гравця
            cameraOffset = mainCamera.transform.position - transform.position;
        }

        void FixedUpdate()
        {
            // Перевірка, чи гравець на землі
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

            // Рух по горизонталі (D - вправо, A - вліво)
            float moveHorizontal = Input.GetKey(KeyCode.D) ? 1f : Input.GetKey(KeyCode.A) ? -1f : 0f;

            // Створити вектор руху на основі вхідних значень
            Vector2 movement = new Vector2(moveHorizontal, rb.velocity.y);

            // Додаємо рух по горизонталі
            rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

            // Стрибок при натисканні пробілу, якщо гравець на землі
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Застосувати силу для стрибка
            }
        }

        void LateUpdate()
        {
            // Оновити позицію камери на основі позиції гравця
            Vector3 newCameraPosition = transform.position + cameraOffset; // Позиція гравця + зміщення
            mainCamera.transform.position = new Vector3(newCameraPosition.x, newCameraPosition.y, mainCamera.transform.position.z);
        }
    }
}
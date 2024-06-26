﻿using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public float speed = 8f; // Швидкість руху гравця
        public Camera mainCamera;

        Rigidbody2D rb; // Посилання на компонент Rigidbody гравця

        void Start()
        {
            rb = GetComponent<Rigidbody2D>(); // Отримати посилання на компонент Rigidbody
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetKey(KeyCode.D) ? 1f : Input.GetKey(KeyCode.A) ? -1f : 0f; // Рух по горизонталі (D - вправо, A - вліво)
            float moveVertical = Input.GetKey(KeyCode.W) ? 1f : Input.GetKey(KeyCode.S) ? -1f : 0f; // Рух по вертикалі (W - вгору, S - вниз)

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // Створити вектор руху на основі вхідних значень

            rb.AddForce(movement * speed); // Застосувати силу до гравця для зміни його швидкості
        }
    }
}
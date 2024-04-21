using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Final : MonoBehaviour
    {
        float time = 1f;
        private float timeDecreaseRate = 1f;

        public Text txtTime;

        private void Start()
        {
            time = PlayerPrefs.GetFloat("time");
            txtTime.text = "0:" + time.ToString();
        }

        void Update()
        {
            // Зменшуємо час на основі часу, що пройшов з останнього кадру та швидкості зменшення
            time -= Time.deltaTime * timeDecreaseRate;

            // Оновлюємо текст, що відображає час
            UpdateTimerText();
        }

        void UpdateTimerText()
        {
            // Перевіряємо, чи час від'ємний, щоб не відображати від'ємні значення
            if (time < 0f)
            {
                time = 0f;
            }

            // Конвертуємо час в хвилини та секунди
            int minutes = Mathf.FloorToInt(time / 60f);
            int seconds = Mathf.FloorToInt(time % 60f);

            // Оновлюємо текст
            txtTime.text = string.Format("{0}:{1:00}", minutes, seconds);

            if (time == 0)
            {
                SceneManager.LoadSceneAsync(9);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                string currentSceneName = SceneManager.GetActiveScene().name;

                if (currentSceneName == "00")
                {
                    SceneManager.LoadSceneAsync(3);

                    PlayerPrefs.SetInt("levelSuc", 0);
                    PlayerPrefs.SetFloat("time", time);
                }
                if (currentSceneName == "00 1")
                {
                    SceneManager.LoadSceneAsync(3);

                    PlayerPrefs.SetInt("levelSuc", 1);
                    PlayerPrefs.SetFloat("time", time);
                }
                if (currentSceneName == "00 2")
                {
                    SceneManager.LoadSceneAsync(3);

                    PlayerPrefs.SetInt("levelSuc", 1);
                    PlayerPrefs.SetFloat("time", time);
                }
                if (currentSceneName == "02")
                {
                    SceneManager.LoadSceneAsync(8);
                }
            }
        }
    }
}
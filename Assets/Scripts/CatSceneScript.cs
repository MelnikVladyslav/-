using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace Assets.Scripts
{
    public class CatSceneScript : MonoBehaviour
    {
        public VideoPlayer videoPlayer; // Посилання на VideoPlayer
        public string nextSceneName; // Ім'я наступної сцени, яку потрібно завантажити

        void Start()
        {
            // Підписуємося на подію завершення відео
            videoPlayer.loopPointReached += OnVideoEnd;
            int a = 0;
            PlayerPrefs.SetInt("currDets", a);
        }

        // Цей метод викликається, коли відео закінчується
        void OnVideoEnd(VideoPlayer vp)
        {
            // Завантажуємо наступну сцену
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
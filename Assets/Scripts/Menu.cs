using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Menu : MonoBehaviour
    {
        public void StartGame(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }

        public void Buy()
        {
            int c = PlayerPrefs.GetInt("coins");
            if (c >= 10)
            {
                c -= 10;
                SceneManager.LoadSceneAsync(3);
            }
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}
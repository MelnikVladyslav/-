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

        public void Exit()
        {
            Application.Quit();
        }
    }
}
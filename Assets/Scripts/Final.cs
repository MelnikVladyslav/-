using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Final : MonoBehaviour
    {

        private void Start()
        {

        }

        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                string currentSceneName = SceneManager.GetActiveScene().name;

                if (currentSceneName == "00")
                {
                    SceneManager.LoadSceneAsync(4);

                    PlayerPrefs.SetInt("levelSuc", 0);
                }
            }
        }
    }
}
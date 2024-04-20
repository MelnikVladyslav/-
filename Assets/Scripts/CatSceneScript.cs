using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class CatSceneScript : MonoBehaviour
    {
        public void Next(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }
    }
}
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Managers
{
    public class LevelManager : MonoBehaviour
    {
        public void EnterLevel(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }
    }
}
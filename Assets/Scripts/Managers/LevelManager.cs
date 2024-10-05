using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Managers
{
    public class LevelManager : MonoBehaviour
    {
        int levelSucces = -1;

        #region levelsUI

        public GameObject level00;

        #endregion

        private void Start()
        {
            levelSucces = PlayerPrefs.GetInt("levelSuc");
        }

        private void Update()
        {
            
        }

        public void EnterLevel(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }
    }
}
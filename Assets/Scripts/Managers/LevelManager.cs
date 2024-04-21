using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Managers
{
    public class LevelManager : MonoBehaviour
    {
        int levelSucces = -1;
        float time = 55;

        #region levelsUI

        public GameObject plRost;
        public GameObject level00;
        public GameObject level011;
        public GameObject level012;
        public GameObject level02;
        public GameObject panelQuest;

        #endregion

        private void Start()
        {
            levelSucces = PlayerPrefs.GetInt("levelSuc");
            if (PlayerPrefs.GetFloat("time") != 0)
            {
                time = PlayerPrefs.GetFloat("time");
            }
        }

        private void Update()
        {
            if (levelSucces == 0)
            {
                level00.SetActive(false);
                panelQuest.SetActive(true);
                plRost.SetActive(true);
                levelSucces = -1;
                PlayerPrefs.SetInt("levelSuc", -1);
            }
            if (levelSucces == 1)
            {
                level00.SetActive(false);
                level011.SetActive(false);
                level012.SetActive(false);
                level02.SetActive(true);
                plRost.SetActive(true);
                levelSucces = -1;
                PlayerPrefs.SetInt("levelSuc", -1);
            }
        }

        public void EnterRoad(int i)
        {
            if (i == 1)
            {
                panelQuest.SetActive(false);
                level011.SetActive(true);
                plRost.transform.position = level011.transform.position;
            }
            if (i == 2)
            {
                panelQuest.SetActive(false);
                level012.SetActive(true);
                plRost.transform.position = level012.transform.position;
            }
        }

        public void EnterLevel(int id)
        {
            SceneManager.LoadSceneAsync(id);

            PlayerPrefs.SetFloat("time", time);
        }
    }
}
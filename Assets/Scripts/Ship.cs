using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();

        private void Start()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].gameObject.SetActive(false);
            }

            int kilkDet = PlayerPrefs.GetInt("currDets");

            for (int i = 0; i < kilkDet; i++)
            {
                gameObjects[i].gameObject.SetActive(true);
            }
        }
    }
}
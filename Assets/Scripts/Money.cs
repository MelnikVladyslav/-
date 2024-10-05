using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Money : MonoBehaviour
    {
        private int coins = 0;
        [SerializeField] private Text txtCoins;

        private void Start()
        {
            coins = PlayerPrefs.GetInt("coins");
            txtCoins.text = coins.ToString();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                coins = PlayerPrefs.GetInt("coins");
                coins++;
                txtCoins.text = coins.ToString();
                PlayerPrefs.SetInt("coins", coins);
                Destroy(this.gameObject);
            }
        }
    }
}
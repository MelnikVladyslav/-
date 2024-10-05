using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Details : MonoBehaviour
    {
        private int currDets = 0;
        [SerializeField] private Text txtDet;

        private void Start()
        {
            currDets = PlayerPrefs.GetInt("currDets");
            txtDet.text = currDets.ToString();
            txtDet.text += "/3";
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                currDets++;
                txtDet.text = currDets.ToString();
                txtDet.text += "/3";
                PlayerPrefs.SetInt("currDets", currDets);
                Destroy(this.gameObject);
            }
        }
    }
}
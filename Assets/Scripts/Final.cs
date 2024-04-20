using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Final : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
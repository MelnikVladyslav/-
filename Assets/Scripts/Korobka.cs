using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Korobka : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
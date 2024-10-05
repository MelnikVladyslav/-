using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capybara : MonoBehaviour
{
    [SerializeField] private int id;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Road"))
        {
            SceneManager.LoadSceneAsync(id);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    private float loadingSpeed = 0.5f;

    private float targetValue;

    private AsyncOperation operation;

    void Start()
    {
        slider.value = 0.0f;

        StartCoroutine(AsyncLoading(2));
    }

    IEnumerator AsyncLoading(int id)
    {
        operation = SceneManager.LoadSceneAsync(id);
        operation.allowSceneActivation = false;

        yield return operation;
    }

    // Update is called once per frame
    void Update()
    {
        targetValue = operation.progress;

        if (operation.progress >= 0.9f)
        {
            targetValue = 1.0f;
        }

        if (targetValue != slider.value)
        {
            slider.value = Mathf.Lerp(slider.value, targetValue, Time.deltaTime * loadingSpeed);
            if (Mathf.Abs(slider.value - targetValue) < 0.01f)
            {
                slider.value = targetValue;
            }
        }

        text.text = ((int)(slider.value * 100)).ToString() + "%";

        if ((int)(slider.value * 100) == 100)
        {
            operation.allowSceneActivation = true;
        }
    }
}

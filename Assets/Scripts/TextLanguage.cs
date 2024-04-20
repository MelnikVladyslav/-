using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class TextLanguage : MonoBehaviour
    {
        public string language;
        Text text;

        public string textUkr;
        public string textEng;

        void Start()
        {
            text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            language = PlayerPrefs.GetString("Language");

            if (language == "" || language == "Eng")
            {
                text.text = textEng;
            }
            else if (language == "Ukr")
            {
                text.text = textUkr;
            }
        }
    }
}
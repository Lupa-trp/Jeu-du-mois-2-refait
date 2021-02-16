using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    private Text uiText;
    private string textToWrite;
    int uiIndex;
    private float time;
    private float timer;
    public void AddWriter(Text uiText, string textToWrite, float time)
    {
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.time = time;

    }

    private void Update()
    {
        if (uiText != null)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                timer += time;
                uiIndex++;
                uiText.text = textToWrite.Substring(0, uiIndex);
            }
        }
    }
}

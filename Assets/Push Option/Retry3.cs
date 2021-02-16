using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry3 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Option()
    {
        SceneManager.LoadScene("o10");
    }

    public void QuitGame()
        {
            Application.Quit();
        }
}
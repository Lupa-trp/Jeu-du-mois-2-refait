using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Option()
    {
        SceneManager.LoadScene("o1");
    }

        public void Extra()
    {
        SceneManager.LoadScene("Ex1");
    }

    public void QuitGame() // Il n'est pas joué, c'est normal
        {
            Application.Quit();
        }
}

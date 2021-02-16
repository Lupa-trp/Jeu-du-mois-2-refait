using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FiveWhy : MonoBehaviour
{
    private const int V = 6;

    public void Continue()
{
    SceneManager.LoadScene(6);
}

}

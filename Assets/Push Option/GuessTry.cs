using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessTry : MonoBehaviour
{
  public void Yes()
{
    SceneManager.LoadScene("o19");
}

public void No()
{
    SceneManager.LoadScene("o20");
}

}
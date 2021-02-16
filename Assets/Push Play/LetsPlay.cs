using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetsPlay : MonoBehaviour
{
  public void Ok()
{
    SceneManager.LoadScene(3);
}

public void No()
{
    SceneManager.LoadScene(4);
}

}

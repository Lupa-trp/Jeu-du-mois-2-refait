using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodTime : MonoBehaviour
{
  public void Yes()
{
    SceneManager.LoadScene("o16");
}

public void No()
{
    SceneManager.LoadScene("o15");
}

}

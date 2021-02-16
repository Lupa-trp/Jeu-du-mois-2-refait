using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouChoose : MonoBehaviour
{
  public void Talk()
{
    SceneManager.LoadScene(18);
}

public void ReturnMenu()
{
    SceneManager.LoadScene(19);
}

}

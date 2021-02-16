using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseAGame : MonoBehaviour
{
  public void Adventure()
{
    SceneManager.LoadScene(8);
}

/*public void RPG()
{
    SceneManager.LoadScene(10);
}
public void Platformer()
{
    SceneManager.LoadScene(12);
}*/

}

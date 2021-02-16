using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOption : MonoBehaviour
{
public void Continue()
{
    SceneManager.LoadScene("Oend");
}
}

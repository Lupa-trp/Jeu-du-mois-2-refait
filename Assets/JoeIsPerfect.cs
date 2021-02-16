using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoeIsPerfect : MonoBehaviour
{
    public void ImJoe()
    {
        SceneManager.LoadScene("o32");
    }

    public void NotJoe()
    {
        SceneManager.LoadScene("o35");
    }

}

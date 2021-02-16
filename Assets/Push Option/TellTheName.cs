using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class TellTheName : MonoBehaviour
{
    public void Continue()
{
    SceneManager.LoadScene("o26");
}
}










   /* public string YourName;
    public GameObject textDisplay;

    public void StoreName()
    {
        YourName = textDisplay.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Uuuh, so you are " + YourName;
    }*/
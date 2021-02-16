using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterYourName : MonoBehaviour
{
    public string YourName;
    public GameObject inputField;

    public void StoreName()
    {
        YourName = inputField.GetComponent<Text>().text;
    }

    public void Continue()
{
    SceneManager.LoadScene("o25");
}

}

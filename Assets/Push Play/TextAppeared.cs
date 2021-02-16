using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppeared : MonoBehaviour
{

    [SerializeField] private TextWriter textWriter;
    private Text HelloU;

    private void Awake()
    {
        HelloU = transform.Find("message").Find("message").GetComponent<Text>();
    }

    private void Start()
    {
        //HelloU.text = "Hello u";
        textWriter.AddWriter(HelloU, "Hello u.", 1f);
    }
}
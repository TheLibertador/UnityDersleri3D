using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoOfPrefs : MonoBehaviour
{
    private int value = 5;
    private int settedValue;
    private string myString = "myString";
    private string yourString;

    private void Awake()
    {
        PlayerPrefs.SetInt("HighScore", value);
        PlayerPrefs.SetString("FirstPlayer", myString);
        
        PlayerPrefs.Save();
    }

    void Start()
    {
        settedValue = PlayerPrefs.GetInt("HighScore");
        yourString = PlayerPrefs.GetString("FirstPlayer");
        
        Debug.Log(settedValue);
        Debug.Log(yourString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

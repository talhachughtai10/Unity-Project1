﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text text2;
    public static string text3;
    private float starttime;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;   
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - starttime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        text2.text = minutes + ":" + seconds;
        text3 = text2.text;
     }
    
}

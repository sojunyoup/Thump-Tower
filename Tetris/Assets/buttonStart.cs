﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void onBackButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void onhomeButton()
    {
        SceneManager.LoadScene("Title");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    public Text scoreText;
    void Start()
    {
        scoreValue = 0;
    }
    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }

    
}

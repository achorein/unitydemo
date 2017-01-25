﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {

    /// <summary>
    /// Singleton
    /// </summary>
    public static GameHelper Instance;

    public Text scoreText;

    private int score = 0;

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of GameHelper!");
        }
        Instance = this;
        Instance.UpdateScore(0);
    }

    public void UpdateScore(int points)
    {
        if (scoreText != null)
        {
            score += points;
            scoreText.text = "SCORE " + score.ToString();
        }
    }
}
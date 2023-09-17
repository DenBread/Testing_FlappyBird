using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _score; // кол-во очков
    private int _bastScore; // рекор по очкам
    private readonly string ScoreKey = "Score";
    
    public static Action OnScoreAdding;

    private void Awake()
    {
        OnScoreAdding += AddScore;

        _bastScore = PlayerPrefs.GetInt(ScoreKey);
    }

    /// <summary>
    /// Узнать кол-во очков
    /// </summary>
    public int GetScore
    {
        get { return _score;}
        private set { }
    }
    
    /// <summary>
    /// Узнать лучшие кол-во очков
    /// </summary>
    public int GetBestScore
    {
        get { return _bastScore; }
        private set{}
    }

    /// <summary>
    /// Добавить очки
    /// </summary>
    private void AddScore()
    {
        _score++;

        if (_score > _bastScore)
        {
            PlayerPrefs.SetInt(ScoreKey, _score);
        }
    }
    
}

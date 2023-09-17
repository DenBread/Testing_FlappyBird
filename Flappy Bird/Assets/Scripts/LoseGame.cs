using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    [SerializeField] private Animator _animatorBird; // анимация птицы
    [SerializeField] private Bird_Jump _birdJump; // 
    [SerializeField] private Background_Scroll[] _backgroundScrolls;
    [SerializeField] private CreatTubes _creatTubes;

    public static Action OnLoseGame;

    private void Awake()
    {
        OnLoseGame += StopGame;
        
    }

    public void StopGame()
    {
        _animatorBird.enabled = false;
        _birdJump.enabled = false;
        _creatTubes.StopMove();

        foreach (var _background in _backgroundScrolls)
        {
            _background.enabled = false;
        }

        
    }
}

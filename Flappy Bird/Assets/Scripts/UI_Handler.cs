using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class UI_Handler : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private TextMeshProUGUI _textScoreInGameplay;

    [SerializeField] private TextMeshProUGUI _textScoreInPanalScore;
    [SerializeField] private TextMeshProUGUI _textBestScoreInPanalScore;

    [SerializeField] private SpriteRenderer[] _medals;

    [SerializeField] private GameObject _panelScore;

    public static Action OnShowUI;
    
    public static UI_Handler instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(this.gameObject);
            OnShowUI += ShowPanelScore;
            return;
        }
        
        Destroy(this.gameObject);
        
    }
    

    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        _textScoreInGameplay.text = _score.GetScore.ToString();
    }

    public void ShowPanelScore()
    {
        _textScoreInPanalScore.text = _score.GetScore.ToString();
        _textBestScoreInPanalScore.text = _score.GetBestScore.ToString();
        _panelScore.SetActive(true);
    }
}

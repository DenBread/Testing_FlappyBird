using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Collition : MonoBehaviour
{
    private bool _isCollition = false;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col != null && !_isCollition)
        {
            Sounds.OnPlaydSound?.Invoke(Sounds.SelectionSound.hit);
            LoseGame.OnLoseGame?.Invoke();
            UI_Handler.OnShowUI?.Invoke();
            _isCollition = true;
            
        }
    }
}

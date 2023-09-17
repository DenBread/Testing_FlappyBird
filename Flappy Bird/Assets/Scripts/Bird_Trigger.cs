using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<TriggerPoint>())
        {
            Sounds.OnPlaydSound?.Invoke(Sounds.SelectionSound.point);
            Score.OnScoreAdding?.Invoke();
        }    
    }
}

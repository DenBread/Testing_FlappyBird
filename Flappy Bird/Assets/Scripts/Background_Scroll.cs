using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroll : MonoBehaviour
{
    private Vector2 _offset;
    [SerializeField] private float _speedX; // скорость перемещения по координате X

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _offset = new Vector2(Time.time * _speedX, 0);
        GetComponent<Renderer>().material.mainTextureOffset = _offset;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StarGampley : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _simulation;
    [SerializeField] private CreatTubes _creatTubes;
    [SerializeField] private Animator _panelStudy;
    
    private BirdController _birdController;

    private void Awake()
    {
        _birdController = new BirdController();
        _birdController.Bird.Jump.performed += context => StartPlay();
    }
    
    private void OnEnable()
    {
        _birdController.Enable();
    }

    private void OnDisable()
    {
        _birdController.Disable();
    }

    public void StartPlay()
    {
        _panelStudy.enabled = true;
        _simulation.simulated = true;
        _creatTubes.enabled = true;

        gameObject.GetComponent<StarGampley>().enabled = false;
        _birdController.Bird.Jump.performed -= context => StartPlay();
    }
}

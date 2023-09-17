using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreatTubes : MonoBehaviour
{
    [SerializeField] private GameObject _prefabsTube; // префаб труб
    private List<GameObject> _tubes = new List<GameObject>(); // лист созданых труб
    private float _addPosX = 5f;

    private Vector3 _pos;

    private void Start()
    {
        _pos = transform.position;
        Creat();
    }

    private void Creat()
    {
        for (int i = 0; i < 3; i++)
        {
            var gm = Instantiate(_prefabsTube) as GameObject;
            gm.transform.position = new Vector3(_pos.x, Random.Range(1f, 2f), 0);
            _tubes.Add(gm);
            _pos.x += _addPosX;
        }
    }

    public void StopMove()
    {
        foreach (var tube in _tubes)
        {
            tube.GetComponent<Wall>().enabled = false;
        }
    }
}

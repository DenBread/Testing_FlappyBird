using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird_Jump : MonoBehaviour
{
    [SerializeField] private  float _powerJump = 5f; // сила прыжка
    private Vector3 _vecUp = Vector3.up; // направление прыжка
    private Rigidbody2D _rb;

    private BirdController _birdController;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _birdController = new BirdController();
        _birdController.Bird.Jump.performed += context => Jump();
    }

    private void OnEnable()
    {
        _birdController.Enable();
    }

    private void OnDisable()
    {
        _birdController.Disable();
    }
    
    
    
    /// <summary>
    /// Функция прыжка
    /// </summary>
    public void Jump()
    {
        _rb.velocity = _vecUp * _powerJump;
        Sounds.OnPlaydSound?.Invoke(Sounds.SelectionSound.wing);
    }
}

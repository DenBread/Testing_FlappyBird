using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioClip _point;
    [SerializeField] private AudioClip _hit;
    [SerializeField] private AudioClip _die;
    [SerializeField] private AudioClip _shoosh;
    [SerializeField] private AudioClip _wing;

    private AudioSource _audioSource;
    private AudioClip _mainSound;

    public static Action<SelectionSound> OnPlaydSound;
    
    public enum SelectionSound
    {
        point, hit, die, shoosh, wing
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        OnPlaydSound+= ChoiseSound;
        
        GameObject.DontDestroyOnLoad(this.gameObject);
    }


    public void ChoiseSound(SelectionSound sound)
    {
        switch (sound)
        {
            case SelectionSound.point:
                _mainSound = _point;
                break;
            case SelectionSound.hit:
                _mainSound = _hit;
                break;
            case SelectionSound.die:
                _mainSound = _die;
                break;
            case SelectionSound.shoosh:
                _mainSound = _shoosh;
                
                break;
            case SelectionSound.wing:
                _mainSound = _wing;
                break;
            default:
                Debug.LogError("звук не выбран");
                break;
        }
        
        _audioSource.PlayOneShot(_mainSound);
    }
}

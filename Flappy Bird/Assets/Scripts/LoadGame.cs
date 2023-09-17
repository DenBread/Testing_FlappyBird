using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    /// <summary>
    /// Звук перемещения
    /// </summary>
    public void SoundPlay()
    {
        Sounds.OnPlaydSound(Sounds.SelectionSound.shoosh);
    }
    
    /// <summary>
    /// Загрузка сцены по индексу
    /// </summary>
    /// <param name="indexScene">индекс сцены</param>
    public void StartScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
}

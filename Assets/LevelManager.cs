using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnEnable()
    {
        Enemy.onCollision += StopGame;
      
    }

    private void OnDisable()
    {
        Enemy.onCollision -= StopGame;
      
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
    
}

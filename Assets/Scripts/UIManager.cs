using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject restartButton;
    private int score=0;

    private void Start()
    {
        scoreText.text = "Score: "+score;
        restartButton.SetActive(false);

    }

    private void OnEnable()
    {
        EnemyDestroyer.onDestroyEnemy += ScoreChange;
        Enemy.onCollision += GameOver;
    }

    private void OnDisable()
    {
        EnemyDestroyer.onDestroyEnemy -= ScoreChange;
        Enemy.onCollision -= GameOver;
        
        
    }

    void GameOver()
    {
        SetRestartButtonActive();
        scoreText.color = Color.red;

    }

    public void RestartButtonClicked()
    {
        restartButton.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        ResetScore();


    }

    void SetRestartButtonActive()
    {
        restartButton.SetActive(true);
    }
    void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score; 
    }
    void ScoreChange()
    {
        score += 10;
        scoreText.text = "Score: "+score;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;


public class EnemySpawner : MonoBehaviour
{
    //object pooling eklenecek
  
    private float minXSpawnPos = -10f;
    private float maxXSpawnPos = 10f;
    private float spawnPosY = 6f;
    private float enemySpawnFreq = 1f;
    private float timer = 0f;

    public GameObject enemyPrefab;

    private void Update()
    {
        
        timer += Time.deltaTime;
        if (timer >= enemySpawnFreq)
        {
            SpawnRandEnemies();
            timer = 0f;
        }
    }

    private void SpawnRandEnemies()
    {
        float randX = Random.Range(minXSpawnPos, maxXSpawnPos);
        Vector3 enemySpawnPos = new(randX, spawnPosY, 0f);
        GameObject newEnemyGO = Instantiate(enemyPrefab, transform);
        newEnemyGO.transform.localPosition = enemySpawnPos;
    }

 
}
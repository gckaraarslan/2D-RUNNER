using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDestroyer : MonoBehaviour
{
    //enemyspawner'ı injecte edip, enemspawner.newenemyGO'e ulaşabilirsek onu destroy edebiliriz... ve bu scripti de level/game manager içinde tutarız..
    private float destroyPosY = -6f;

    public delegate void OnDestroyEnemy();

    public static  OnDestroyEnemy onDestroyEnemy;
   


    void Update()
    {
        DestroyEnemy();   //bunu burda değil de, level/game manager içinde kullansak...
    }

    void DestroyEnemy( ) //inject edip diğer manager'a bu fonksiyonun içine bir obje parametresi verirsek... o parametreyi de enemyspawnerda spawn olan nesneyi parametre olarak verirsek 
    {
        if (transform.position.y <= destroyPosY)
        {
            
            Destroy(gameObject);
            onDestroyEnemy?.Invoke();
           
    
        }
    }
  
    
}
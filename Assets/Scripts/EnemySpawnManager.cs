using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float spawnDelay;
    private List<GameObject> enemies = new List<GameObject>();

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i=0; i < spawnPoints.Length; i++)
            {
                GameObject newEnemy = Instantiate(enemy, spawnPoints[i].transform);
                enemies.Add(newEnemy);
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }

    private void Update()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                enemies.Remove(enemies[i]);
            }
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
}

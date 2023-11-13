using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDeEnemigos : MonoBehaviour
{
    public int enemigosEnEscenaMax;
    public Transform xRangeLeft, xRangeRight, yRangeUp, yRangeDown;

    public GameObject[] enemies;
    
    public float timeSpawn, repeatSpawnRate;
    public ArenaManager Arena;

    void Start()
    {
        
        Arena = FindObjectOfType<ArenaManager>();

        CantidadDeEnemigos();
        
    }


    void Update()
    {
        
    }

    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);
        GameObject enemie = Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, gameObject.transform.rotation);

    }

    public void CantidadDeEnemigos()
    {

        enemigosEnEscenaMax = 9 * Arena.hordas;

        for (int i = 0; i < enemigosEnEscenaMax; i++)
        {
            Invoke("SpawnEnemies", timeSpawn);
        }
    }
}

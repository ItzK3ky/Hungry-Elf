using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Global Variables")]
    [SerializeField] private FloatSO difficulty;

    [Header("Prefabs")]
    [SerializeField] private List<GameObject> Enemys;

    [Header("Attributes")]
    [SerializeField] private float spawnChance;

    void FixedUpdate()
    {
        if(spawnChance * difficulty.Value >= Random.Range(1, 100))
            SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        float spawnPositionX = Mathf.Clamp(transform.position.x + Random.Range(-15, 15), -15 + transform.position.x, 15 + transform.position.x);
        float spawnPositionY = Mathf.Clamp(transform.position.y + Random.Range(-15, 15), -15 + transform.position.y, 15 + transform.position.y);

        Vector3 spawnPosition = new Vector3(spawnPositionX, spawnPositionY, 0);

        Instantiate(Enemys[0], spawnPosition, Quaternion.Euler(0, 0 , 0));
    }
}

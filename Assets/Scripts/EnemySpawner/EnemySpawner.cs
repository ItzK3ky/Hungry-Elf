using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Global Variables")]
    [SerializeField] private FloatSO difficulty;
    [SerializeField] private FloatSO maxEnemyCap;
    [SerializeField] private FloatSO amountOfEnemys;

    [Header("Prefabs")]
    [SerializeField] private List<GameObject> Enemys;
    [SerializeField] private List<GameObject> BiggerEnemys;

    [Header("Attributes")]
    [SerializeField] private float spawnChance;
    [SerializeField] private float biggerEnemySpawnFactor;

    void FixedUpdate()
    {
        if (amountOfEnemys.Value < maxEnemyCap.Value)
        {
            if (spawnChance / 10 * difficulty.Value >= Random.Range(1, 100))
                SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        float spawnPositionX = Mathf.Clamp(transform.position.x + Random.Range(-15, 15), -15 + transform.position.x, 15 + transform.position.x);
        float spawnPositionY = Mathf.Clamp(transform.position.y + Random.Range(-15, 15), -15 + transform.position.y, 15 + transform.position.y);

        Vector3 spawnPosition = new Vector3(spawnPositionX, spawnPositionY, 0);

        if(Mathf.Clamp(biggerEnemySpawnFactor * difficulty.Value, 0, 40) >= Random.Range(1, 100))
        {
            Instantiate(BiggerEnemys[0], spawnPosition, Quaternion.Euler(0, 0, 0));
        }
        else
        {
            Instantiate(Enemys[0], spawnPosition, Quaternion.Euler(0, 0 , 0));
        }

        amountOfEnemys.ChangeAmountBy(1);
    }
}

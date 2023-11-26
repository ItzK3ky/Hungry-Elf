using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Gloabl Variables")]
    [SerializeField] private FloatSO difficulty;
    [SerializeField] private FloatSO maxEnemyCap;
    [SerializeField] private FloatSO amountOfEnemys;

    [Space]

    [SerializeField] private float difficultyIncreaseSpeed;

    void Start()
    {
        difficulty.ResetAmount();
        maxEnemyCap.ResetAmount();
        amountOfEnemys.ResetAmount();
    }

    void FixedUpdate()
    {
        difficulty.ChangeAmountBy(difficultyIncreaseSpeed/50);
        maxEnemyCap.ChangeAmountBy(difficultyIncreaseSpeed * 10);
    }
}

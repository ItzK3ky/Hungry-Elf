using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Gloabl Variables")]
    [SerializeField] private FloatSO difficulty;

    [Space]

    [SerializeField] private float difficultyIncreaseSpeed;

    void Start()
    {
        difficulty.ResetAmount();
    }

    void FixedUpdate()
    {
        difficulty.ChangeAmountBy(difficultyIncreaseSpeed/50);
    }
}

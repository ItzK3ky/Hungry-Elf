using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("GameEvents")]
    [SerializeField] private GameEvent killEnemyEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            killEnemyEvent.Raise(this, collision.gameObject);
            Destroy(gameObject);
        }
    }
}

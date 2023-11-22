using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float damage;

    [Header("GameEvents")]
    [SerializeField] private GameEvent damageEnemyEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            List<object> data = new List<object>();
            data.Add(collision.gameObject);
            data.Add(damage);

            damageEnemyEvent.Raise(this, data);

            Destroy(gameObject, 0.01f);
        }
    }
}

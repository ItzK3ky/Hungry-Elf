using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float damage;

    [Header("GameEvents")]
    [SerializeField] private GameEvent damagePlayerEvent;

    private GameObject player;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        if(player != null)
            rb.MovePosition(Vector2.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.fixedDeltaTime));
    }

    private void KillEnemy()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            damagePlayerEvent.Raise(this, damage);

            KillEnemy();
        }
    }
}

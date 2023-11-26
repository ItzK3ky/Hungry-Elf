using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float damage;
    [SerializeField] private float health;
    [SerializeField] private float movementSpeed;

    [Header("Global Variables")]
    [SerializeField] private FloatSO amountOfEnemys;

    [Header("GameEvents")]
    [SerializeField] private GameEvent damagePlayerEvent;

    private Transform player;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if(player != null)
            rb.MovePosition(Vector2.MoveTowards(transform.position, player.position, movementSpeed * Time.fixedDeltaTime));
    }

    private void KillEnemy()
    {
        amountOfEnemys.ChangeAmountBy(-1);
        Destroy(gameObject);
    }

    public void dealDamage(Component sender, List<object> data)
    {
        if ((GameObject) data[0] == gameObject)
        {
            health -= (float)data[1];
            if (health <= 0)
                KillEnemy();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            List<object> data = new List<object>();
            data.Add(damage);

            damagePlayerEvent.Raise(this, data);

            KillEnemy();
        }
    }
}

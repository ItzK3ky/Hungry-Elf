using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float damage;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float fireCooldownInSec;

    [Header("Prefabs")]
    [SerializeField] private GameObject bulletPrefab;

    private float cooldownTimer;

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0) && cooldownTimer <= 0)
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        if(cooldownTimer > 0)
        {
            Debug.Log("hosenmann");
            cooldownTimer -= 1 * Time.fixedDeltaTime;
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, bulletSpeed));

        cooldownTimer = fireCooldownInSec;
    }
}

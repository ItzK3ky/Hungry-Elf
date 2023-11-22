using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFighting : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float bulletSpeed;

    [Header("Prefabs")]
    [SerializeField] private GameObject bulletPrefab;

    void Update()
    {
        //Make player look towards cursor
        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(bulletSpeed, 0f));
    }
}
